namespace Uni_Books
{
    partial class frmEnter1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnter1));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.pnlBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.panel1);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 61);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(326, 90);
            this.pnlBottom.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCancel);
            this.panel1.Controls.Add(this.cmdOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(126, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 90);
            this.panel1.TabIndex = 0;
            // 
            // cmbCancel
            // 
            this.cmbCancel.Location = new System.Drawing.Point(59, 61);
            this.cmbCancel.Name = "cmbCancel";
            this.cmbCancel.Size = new System.Drawing.Size(129, 23);
            this.cmbCancel.TabIndex = 2;
            this.cmbCancel.Text = "Cancel";
            this.cmbCancel.UseVisualStyleBackColor = true;
            this.cmbCancel.Click += new System.EventHandler(this.cmbCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(59, 16);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(129, 39);
            this.cmdOK.TabIndex = 1;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(13, 13);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(141, 16);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "Please Enter Value";
            // 
            // txt
            // 
            this.txt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(0, 35);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(326, 26);
            this.txt.TabIndex = 0;
            this.txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KEYPRESS);
            // 
            // frmEnter1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 151);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.pnlBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnter1";
            this.Text = "Enter Value";
            this.pnlBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmbCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txt;
    }
}