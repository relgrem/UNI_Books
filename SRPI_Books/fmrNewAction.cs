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
    public partial class fmrNewAction : Form
    {
        public fmrNewAction()
        {
            InitializeComponent();
        }

       
        public void Initialize(ACCT With_Acct)
        {
            Refresh_Fields();
            lblAcctNumber.Text = With_Acct.ID;
            lblName.Text = With_Acct.name;
            Set_dateTime();
        }

        public void Initialize(string Acct_ID, string name)
        {
            Refresh_Fields();
            lblAcctNumber.Text = Acct_ID ;
            lblName.Text = name;
            Set_dateTime();
        }

        public void Set_dateTime()
        {
            DTP.Value = DateTime.Now;
            int H = DateTime.Now.Hour;
            if (H == 0)
            {
                rbAM.Checked = true;
                HH.Value = 12;
            }
            else if (H == 12)
            {
                rbPM.Checked = true;
                HH.Value = 12;
            }
            else if (H > 12)
            {
                rbPM.Checked = true;
                HH.Value = H - 12;
            }
            else
            {
                rbAM.Checked = true;
                HH.Value = 12;
            }
            if (Properties.Settings.Default.auto_date)
            {
                gbDate.Enabled = false;
                gbTime.Enabled = false;
            }
            MM.Value = DateTime.Now.Minute;
            SS.Value = DateTime.Now.Second;
            if (!Properties.Settings.Default.Keep_Time) gbTime.Enabled = false;
        }

        public void Refresh_Fields()
        {
            rbBuyIn.Text = Properties.Settings.Default.Increase_descr;
            rbCount.Text = Properties.Settings.Default.Count_descr;
            rbNothing.Text = Properties.Settings.Default.Nothing_descr;
            rbPayOut.Text = Properties.Settings.Default.Decrease_descr;
            //----------------------------------
            if (Properties.Settings.Default.Default_activity == "Nothing") rbNothing.Checked = true;
            if (Properties.Settings.Default.Default_activity == "Count") rbCount.Checked = true;
            if (Properties.Settings.Default.Default_activity == "Increase") rbBuyIn.Checked = true;
            if (Properties.Settings.Default.Default_activity == "Decrease") rbPayOut.Checked = true;
            //-----------------------------------
            if (Properties.Settings.Default.Increase_descr == "-DISABLE-") rbBuyIn.Visible = false;
            if (Properties.Settings.Default.Decrease_descr == "-DISABLE-") rbPayOut.Visible = false;
            if (Properties.Settings.Default.Nothing_descr == "-DISABLE-") rbNothing.Visible = false;
            if (Properties.Settings.Default.Count_descr == "-DISABLE-") rbCount.Visible = false;
            txtAmount.Text = "";
            if (Properties.Settings.Default.Default_amount > 0)
                txtAmount.Text = Properties.Settings.Default.Default_amount.ToString();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public ACTIVITY.ActionType  Selected_ActionType()
        {
            if (rbBuyIn.Checked) return ACTIVITY.ActionType.Increase;
            if (rbCount.Checked) return ACTIVITY.ActionType.Count ;
            if (rbPayOut.Checked) return ACTIVITY.ActionType.Decrease ;
            return ACTIVITY.ActionType.nothing;
        }

        public string User_id()
        {
            return lblAcctNumber.Text;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public ACTIVITY Get_Activity()
        {
            ACTIVITY rv = new ACTIVITY("");
            rv.UID = lblAcctNumber.Text;
            rv.Action = Selected_ActionType();
            if (Properties.Settings.Default.Whole_Numbers)
            {
                rv.Amount = Int_VAL(txtAmount.Text);
            }
            else
            {
                rv.Amount = VAL(txtAmount.Text);
            }
            //rv.record_date = DateTime.Now;
            rv.record_date = DTV();
            return rv;
        }

        private DateTime DTV()
        {
            DateTime rv = DTP.Value.Date;
            rv=rv.AddHours(Convert.ToInt32(HH.Value));
            if (rbPM.Checked)            rv=rv.AddHours(12);
            rv=rv.AddMinutes(Convert.ToInt32( MM.Value));
            rv=rv.AddSeconds(Convert.ToInt32(SS.Value));
            return rv;
        }

        private void AMT_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar=='\r')
            {
                if (gbDate.Enabled )
                {
                    DTP.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void Date_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private decimal VAL(string FromString)
        {
            try
            {
                return decimal.Parse(FromString);
            }
            catch
            {
                return 0;
            }
        }

        private decimal Int_VAL(string FromString)
        {
            try
            {
                return Convert.ToInt32(FromString);
            }
            catch
            {
                return 0;
            }
        }
    }

}
