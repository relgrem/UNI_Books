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
    public partial class frmEnter1 : Form
    {
        public frmEnter1()
        {
            InitializeComponent();
        }

        public void Initialize(string Prompt, string default_value,string pwd_char)
        {
            if (pwd_char !="") txt.PasswordChar = pwd_char.ToCharArray()[0] ;
            lblPrompt.Text = Prompt;
            txt.Text = default_value;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string Value()
        {
            return txt.Text;
        }

        private void cmbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void KEYPRESS(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar=='\r')
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }

}
