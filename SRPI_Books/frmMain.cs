using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Uni_Books
{
    public partial class frmMain : Form
    {
        public UniBook_System USYS = new UniBook_System();
        //---------------------------------------------------
        public ACCT current_account;
        public bool unsaved_changes=false; 
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool Security_PASSed = true;
            this.Text = "Unibook - " + Properties.Settings.Default.Account_descr;
            if (Properties.Settings.Default.pwd !="")
            {
                frmEnter1 f = new frmEnter1();
                f.Initialize("Enter Password:", "", "@");
                if (f.ShowDialog()==DialogResult.OK )
                {
                    clsCrypto ENC = new clsCrypto();
                    ENC.Set_Keys("BB61616UEUE", "JPM2021");
                    ENC.Encrypt_to_Buffer(f.Value());
                    Security_PASSed = (ENC.Get_Buffer_Base64() == Properties.Settings.Default.pwd);
                    ENC = null;
                    if (!Security_PASSed )
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show("Login Failed", "Access Denied", buttons);
                        System.Windows.Forms.Application.Exit();
                        return;
                    }
                }
            }
            if (Security_PASSed )
            {
                Load_Data();
                Refresh_List();
            }
        }

        private void Clear_Account_Activity()
        {
            LV_Activity.Items.Clear();
            lblACCTNumber.Text = "";
            lblACCT_Name.Text = "";
            this.current_account = null;
        }

        private void Form1_Close(object sender, FormClosingEventArgs e)
        {
            if (unsaved_changes)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show("Do you want to save your changes?", "Save", buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Save();
                }
            }

         }

        public void Load_Data()
        {
            try
            {
                this.USYS.Clear();
                if (!File.Exists(Properties.Settings.Default.filename)) return;
                clsFile_Header FH = new clsFile_Header();
                StreamReader SR = new StreamReader(Properties.Settings.Default.filename);
                char[] cbuf = new char[200];
                string h = "";
                SR.Read(cbuf, 0, 200).ToString() ;
                h = new string(cbuf);
                FH.header_length = 200;
                FH.Populate(h);
                FH.validator_1 = Properties.Settings.Default.pwd;
                if (FH.validate(h)!=clsFile_Header.load_result.Successful)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    string mb = "The selected file does not contain valid data." + '\n';
                    foreach (string s in  FH.exceptions )
                    {
                        mb += s + '\n';
                    }
                    result = MessageBox.Show(mb, "Load Failed", buttons);
                }
                string D = SR.ReadToEnd();
                SR.Close();
                if (Properties.Settings.Default.pwd != "")
                {
                    clsCrypto ENC = new clsCrypto();
                    ENC.Set_Keys(Properties.Settings.Default.pwd, Properties.Settings.Default.app_key);
                    D = ENC.Decrypt_From_Base64(D);
                    ENC = null;
                }
                string[] parse1 = D.Split('©');
                string accounts = parse1[0];
                string activities = parse1[1];
                this.USYS.Accounts = new ACCTs(accounts);
                this.USYS.Actions = new Activities(activities);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Save()
        {
            try
            {
                if (File.Exists(Properties.Settings.Default.filename))
                {
                    File.Delete(Properties.Settings.Default.filename );
                }
                clsFile_Header FH = new clsFile_Header();

                FH.header_length = 200;
                FH.file_version = "1.0";
                FH.app_id = Properties.Settings.Default.app_key;
                FH.file_id = "Account data file";
                FH.validator_1 = Properties.Settings.Default.pwd;

                StreamWriter W = new StreamWriter(Properties.Settings.Default.filename);
                W.Write(FH.DLM());
                //Re-Order the detail records in case and new entries
                //Have been added out of chronological order
                this.USYS.Actions.items.Sort((x, y) => DateTime.Compare(x.record_date, y.record_date));
                string fullfile = this.USYS.Accounts.DLM() + '©' + this.USYS.Actions.DLM();

                if (Properties.Settings.Default.pwd!="")
                {
                    clsCrypto ENC = new clsCrypto();
                    ENC.Set_Keys(Properties.Settings.Default.pwd, Properties.Settings.Default.app_key);
                    ENC.Encrypt_to_Buffer(fullfile);
                    fullfile = ENC.Get_Buffer_Base64();
                    ENC = null;
                }
                W.Write(fullfile);
                W.Close();
                Set_Status("Data save complete.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                unsaved_changes = false;
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            frmNewACCT f = new frmNewACCT();
            f.StartPosition = FormStartPosition.CenterParent;
            if (Properties.Settings.Default.auto_acct_ids)
            {
                f.Initialize(this.USYS.Accounts.New_UID());
            }
            else
            {

            }
            if (f.ShowDialog()==DialogResult.OK)
            {
                this.USYS.Accounts.Add(f.Account_Name() ,f.Account_ID());
                Refresh_List();
                LV_Activity.Items.Clear();
                lblACCTNumber.Text="-";
                lblACCT_Name.Text = "-";
                unsaved_changes = true;
            }
        }

        private void LV_Accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_Accounts.SelectedItems.Count == 0) return;
            this.current_account = this.USYS.Accounts.Get_Acct(LV_Accounts.SelectedItems[0].Text);
            lblACCTNumber.Text = this.current_account.ID;
            lblACCT_Name.Text = this.current_account.name;
            Refresh_Actions();

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void Refresh_List()
        {
            bool ShowAvg = Properties.Settings.Default.Acct_Show_Average;
            decimal TBAL = 0;
            decimal cBal = 0;
            LV_Accounts.Items.Clear();
            chAverage.Width=0;
            if (ShowAvg) chAverage.Width=100;
            foreach (ACCT A in this.USYS.Accounts.items )
            {
                if (FilterPass(A))
                {
                    ListViewItem lvi = LV_Accounts.Items.Add(A.ID);
                    lvi.SubItems.Add(A.name);
                    cBal = this.USYS.Actions.Get_Balance(A.ID);
                    TBAL += cBal;
                    lvi.SubItems.Add(cBal.ToString(Properties.Settings.Default.Amount_format));
                    if (ShowAvg) lvi.SubItems.Add(this.USYS.Actions.Get_Average(A.ID).ToString("0.0"));
                }
            }
            lblCount.Text=this.USYS.Accounts.items.Count.ToString() + " Accounts";
            lblTotal.Text = TBAL.ToString(Properties.Settings.Default.Amount_format);
            LV_Color(LV_Accounts, Properties.Settings.Default.LV1_A, Properties.Settings.Default.LV1_B);
        }

        private bool FilterPass(ACCT A)
        {
            if (txtSearchName.Text.Length == 0 && txtSearchID.Text.Length == 0) return true;
            if (txtSearchName.Text.Length>0)
            {
                if (!A.name.ToUpper().Contains(txtSearchName.Text.ToUpper())) return false;
            }
            if (txtSearchID.Text.Length > 0)
            {
                if (!A.ID.ToUpper().Contains(txtSearchID.Text.ToUpper())) return false;
            }
            return true;
        }

        private void Refresh_Actions()
        {
            Refresh_USYS_Properties();
            lblACCTNumber.Text = "-";
            lblACCT_Name.Text = "-";
            LV_Activity.Items.Clear();
            if (this.current_account == null) return;
            lblACCTNumber.Text = this.current_account.ID;
            lblACCT_Name.Text = this.current_account.name;
            foreach (ACTIVITY A in this.USYS.Actions.items)
            {
                if (A.UID==this.current_account.ID )
                {
                    ListViewItem lvi = LV_Activity.Items.Add(A.record_date.ToString());
                    lvi.SubItems.Add(this.USYS.Actions.Get_Activty_String(A.Action));
                    lvi.SubItems.Add(A.Amount.ToString(Properties.Settings.Default.Amount_format));
                }
            }
            LV_Color(LV_Activity, Properties.Settings.Default.LV2_A, Properties.Settings.Default.LV2_B);
        }

        private void Refresh_USYS_Properties()
        {
            this.USYS.Description = Properties.Settings.Default.Account_descr;
            this.USYS.Actions.desc_Count = Properties.Settings.Default.Count_descr;
            this.USYS.Actions.desc_Decrease  = Properties.Settings.Default.Decrease_descr;
            this.USYS.Actions.desc_Increase = Properties.Settings.Default.Increase_descr;
            this.USYS.Actions.desc_Nothing = Properties.Settings.Default.Nothing_descr;
        }

        private void cmdNewAction_Click(object sender, EventArgs e)
        {
            if (lblACCTNumber.Text.Length < 4) return;
            fmrNewAction f = new fmrNewAction();
            f.StartPosition = FormStartPosition.CenterParent;
            f.Initialize(lblACCTNumber.Text, lblACCT_Name.Text);
            if (f.ShowDialog()==DialogResult.OK )
            {
                this.USYS.Actions.items.Add(f.Get_Activity());
                Refresh_Actions();
                Refresh_List();
                unsaved_changes = true;
            }
            f.Dispose();
        }

        public void LV_Color(ListView  ToLV,Color Color1, Color color2)
        {
            ToLV.GridLines = true;
            ToLV.FullRowSelect = true;
            bool toggle = false;
            foreach (ListViewItem lvi in ToLV.Items)
            {

                toggle = !toggle;
                if (toggle)
                {
                    lvi.BackColor = Color1;
                }
                else
                {
                    lvi.BackColor = color2;
                }
            }
        }

        private void cmdSettings_Click(object sender, EventArgs e)
        {
            frmSettings f = new frmSettings();
            f.StartPosition = FormStartPosition.CenterParent;
            f.Initialize();
            f.ShowDialog();
        }

        private void mnuExport_Bal_Click(object sender, EventArgs e)
        {
            SD.Filter = "Tab Files|*.tab|Text Files|*.txt|All Files|*.*";
            SD.DefaultExt = ".tab";
            if (SD.ShowDialog()==DialogResult.OK)
            {
                StreamWriter FILE = new StreamWriter(SD.FileName);
                decimal cBal = 0;
                string line = "";
                LV_Accounts.Items.Clear();
                line = "ID\tAccount Name\tBalance";
                FILE.WriteLine(line);
                foreach (ACCT A in this.USYS.Accounts.items)
                {
                    cBal = this.USYS.Actions.Get_Balance(A.ID);
                    line = A.ID + '\t';
                    line += A.name + '\t';
                    line += cBal.ToString("0.00");
                    FILE.WriteLine(line);
                }
                FILE.Close();
                Set_Status( "Export File Saved: " + SD.FileName);
            }
        }

        private void TMR_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = "Ready";
            TMR.Enabled = false;
            PB.Value = 0;
        }

        public void Set_Status(string message)
        {
            lblStatus.Text = message;
            TMR.Enabled = true;
        }

        private void mnuExport_All_Click(object sender, EventArgs e)
        {
            SD.Filter = "Tab Files|*.tab|Text Files|*.txt|All Files|*.*";
            SD.DefaultExt = ".tab";
            if (SD.ShowDialog() == DialogResult.OK)
            {
                StreamWriter FILE = new StreamWriter(SD.FileName);
                string line = "";
                LV_Accounts.Items.Clear();
                line = "ID\tAccount Name\tDate\tAction\tAmount";
                FILE.WriteLine(line);
                this.USYS.Actions.items.Sort((x, y) => DateTime.Compare(x.record_date, y.record_date));
                ACCT Current_ACCT = new ACCT("","");
                PB.Maximum = this.USYS.Actions.items.Count;
                foreach (ACTIVITY A in this.USYS.Actions.items)
                {
                    if (Current_ACCT.ID != A.UID) Current_ACCT = this.USYS.Accounts.Get_Acct(A.UID);
                    line = A.UID + '\t';
                    line += Current_ACCT.name + '\t';
                    line += A.record_date.ToString("MM-dd-yyyy HH:mm am/pm") + '\t';
                    line += A.Action.ToString() + '\t';
                    line += A.Amount.ToString("0.00");
                    FILE.WriteLine(line);
                    PB.Value++;
                }
                FILE.Close();
                Set_Status("Export File Saved: " + SD.FileName);
            }
        }

        private void cmdClearAll_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;
            result = MessageBox.Show("This will clear all accounts and activity.\nAre you sure you want to do that???", "Clear All", buttons);
            if (result==DialogResult.OK)
            {
                this.USYS.Clear();
                Refresh_List();
                LV_Activity.Items.Clear();
            }
            return;
        }

        private void cmdUnfilter_Click(object sender, EventArgs e)
        {
            txtSearchID.Text = "";
            txtSearchName.Text = "";
            Clear_Account_Activity();
            Refresh_List();
        }

        private void cmdRefreshFilter_Click(object sender, EventArgs e)
        {
            Clear_Account_Activity();
            Refresh_List();
        }
    }


}
