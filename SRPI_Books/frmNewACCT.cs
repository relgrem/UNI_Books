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
    public partial class frmNewACCT : Form
    {
        private List<string> id_list;
        private bool Keyed_ID_Mode = false;
        public frmNewACCT()
        {
            InitializeComponent();
        }

        public void Initialize(string ID_Number)
        {
            lblID.Text = "";
            txtID.Text = ID_Number;
            gbID.Enabled = false;
        }

        public void Initialize(List<string> existing_ids)
        {
            this.id_list = existing_ids;
            txtID.Text = "";
            lblID.Text = "New";
            gbID.Enabled = true;
            this.Keyed_ID_Mode = true;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            Done();
        }

        public string Account_Name()
        {
            return txtName.Text;
        }

        public string Account_ID()
        {
            return txtID.Text;
        }

        private void Key_Pressed1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Done();
            }
            if (e.KeyCode==Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void ID_Keyed(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar =='\r' ) txtName.Focus();
        }

        private void Done()
        {
            if (txtName.Text=="")
            {
                lblID.Text = "Name Required";
                txtName.BackColor = Color.LightSalmon;
                txtName.Focus();
                return;
            }
            if (this.Keyed_ID_Mode )
            {
                if (this.id_list.Contains(txtID.Text))
                {
                    lblID.Text = "ID Exists";
                    txtID.BackColor = Color.LightSalmon;
                    txtID.Focus();
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
