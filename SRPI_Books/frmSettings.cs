using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Uni_Books
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            pic1A.BackColor = Properties.Settings.Default.LV1_A;
            pic1B.BackColor = Properties.Settings.Default.LV1_B;
            pic2A.BackColor = Properties.Settings.Default.LV2_A;
            pic2B.BackColor = Properties.Settings.Default.LV2_B;
            txtFile.Text = Properties.Settings.Default.filename;
            chkAutoIDs.Checked = Properties.Settings.Default.auto_acct_ids;
            chkTimestamp.Checked = !Properties.Settings.Default.auto_date;
            txtDesc.Text = Properties.Settings.Default.Account_descr;
            cmbDesc_Nothing.Text = Properties.Settings.Default.Nothing_descr;
            cmbDesc_Count.Text = Properties.Settings.Default.Count_descr;
            cmbDesc_Decrease.Text = Properties.Settings.Default.Decrease_descr;
            cmbDesc_Increase.Text = Properties.Settings.Default.Increase_descr;
            chkWholeNumbers.Checked = Properties.Settings.Default.Whole_Numbers;
            chkKeepTime.Checked = Properties.Settings.Default.Keep_Time;
            cmbDefault_Activity.Text = Properties.Settings.Default.Default_activity;
            chkShowBalance.Checked = Properties.Settings.Default.Acct_Show_Balance;
            chkShowAverage.Checked = Properties.Settings.Default.Acct_Show_Average;
            txtAmountFormat.Text = Properties.Settings.Default.Amount_format;
            txtAmount.Text = Properties.Settings.Default.Default_amount.ToString();
            txtPwd.Text = "";
            txtPwd2.Text = "";
            if (Properties.Settings.Default.pwd!="")
            {
                clsCrypto ENC = new clsCrypto();
                ENC.Set_Keys("BB61616UEUE", "JPM2021");
                ENC.Decrypt_From_Base64(Properties.Settings.Default.pwd);
                string p = ENC.Get_Buffer_Base64();
                txtPwd.Text = p;
                txtPwd2.Text = p;
            }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text != txtPwd2.Text)
            {
                lblTest.Text = "Passwords do not match!";
                txtPwd2.BackColor = Color.LightSalmon;
                txtPwd2.Text = "";
                txtPwd2.Focus();
                return;
            }
                if (txtPwd2.Text.Contains('ÿ'))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show("Your password contains illegal characters.", "Can not save", buttons);
                return;
            }
            //Properties.Settings
            Properties.Settings.Default.pwd = "";
            if (txtPwd.Text!="")
            {
                clsCrypto ENC = new clsCrypto();
                ENC.Set_Keys("BB61616UEUE", "JPM2021");
                ENC.Encrypt_to_Buffer(txtPwd.Text);
                Properties.Settings.Default.pwd = ENC.Get_Buffer_Base64();
                ENC = null;
            }
            Properties.Settings.Default.LV1_A = pic1A.BackColor;
            Properties.Settings.Default.LV1_B = pic1B.BackColor;
            Properties.Settings.Default.LV2_A = pic2A.BackColor;
            Properties.Settings.Default.LV2_B = pic2B.BackColor;
            Properties.Settings.Default.filename = txtFile.Text;
            Properties.Settings.Default.auto_date = !chkTimestamp.Checked;
            Properties.Settings.Default.auto_acct_ids = chkAutoIDs.Checked;
            Properties.Settings.Default.Account_descr = txtDesc.Text;
            Properties.Settings.Default.Nothing_descr = cmbDesc_Nothing.Text;
            Properties.Settings.Default.Count_descr = cmbDesc_Count.Text;
            Properties.Settings.Default.Decrease_descr = cmbDesc_Decrease.Text;
            Properties.Settings.Default.Increase_descr = cmbDesc_Increase.Text;
            Properties.Settings.Default.Whole_Numbers = chkWholeNumbers.Checked;
            Properties.Settings.Default.Keep_Time = chkKeepTime.Checked;
            Properties.Settings.Default.Default_activity = cmbDefault_Activity.Text;
            Properties.Settings.Default.Acct_Show_Average = chkShowAverage.Checked;
            Properties.Settings.Default.Acct_Show_Balance = chkShowBalance.Checked;
            Properties.Settings.Default.Amount_format = txtAmountFormat.Text;
            Properties.Settings.Default.Default_amount = VAL(txtAmount.Text);
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pic1A_Click(object sender, EventArgs e)
        {
            CD.Color = pic1A.BackColor;
            if (CD.ShowDialog() == DialogResult.OK) pic1A.BackColor = CD.Color;
        }

        private void pic1B_Click(object sender, EventArgs e)
        {
            CD.Color = pic1B.BackColor;
            if (CD.ShowDialog() == DialogResult.OK) pic1B.BackColor = CD.Color;

        }

        private void pic2A_Click(object sender, EventArgs e)
        {
            CD.Color = pic2A.BackColor;
            if (CD.ShowDialog() == DialogResult.OK) pic2A.BackColor = CD.Color;
        }

        private void pic2B_Click(object sender, EventArgs e)
        {
            CD.Color = pic2B.BackColor;
            if (CD.ShowDialog() == DialogResult.OK) pic2B.BackColor = CD.Color;

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void cmdFileName_Click(object sender, EventArgs e)
        {
            SD.DefaultExt = ".account.dat";
            SD.Filter = "Account Files|*.account.dat|All Files|*.*";
            if (SD.ShowDialog()==DialogResult.OK )
            {
                txtFile.Text = SD.FileName;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chkKeepTime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private decimal VAL(string FromString)
        {
            try
            {
                return Convert.ToDecimal(FromString);
            }
            catch
            {
                return 0;
            }
        }
    }


}
