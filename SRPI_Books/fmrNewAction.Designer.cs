namespace Uni_Books
{
    partial class fmrNewAction
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrNewAction));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAcctNumber = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCount = new System.Windows.Forms.RadioButton();
            this.rbPayOut = new System.Windows.Forms.RadioButton();
            this.rbBuyIn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.HH = new System.Windows.Forms.NumericUpDown();
            this.MM = new System.Windows.Forms.NumericUpDown();
            this.SS = new System.Windows.Forms.NumericUpDown();
            this.rbAM = new System.Windows.Forms.RadioButton();
            this.rbPM = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbNothing = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbDate.SuspendLayout();
            this.gbTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblAcctNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 38);
            this.panel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(192, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblAcctNumber
            // 
            this.lblAcctNumber.AutoSize = true;
            this.lblAcctNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctNumber.Location = new System.Drawing.Point(12, 9);
            this.lblAcctNumber.Name = "lblAcctNumber";
            this.lblAcctNumber.Size = new System.Drawing.Size(82, 24);
            this.lblAcctNumber.TabIndex = 0;
            this.lblAcctNumber.Text = "ACCT #";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 95);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdCancel);
            this.panel3.Controls.Add(this.cmdOK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(181, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 95);
            this.panel3.TabIndex = 0;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(37, 49);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(138, 39);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(37, 4);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(138, 39);
            this.cmdOK.TabIndex = 10;
            this.cmdOK.Text = "OKAY";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNothing);
            this.groupBox1.Controls.Add(this.rbCount);
            this.groupBox1.Controls.Add(this.rbPayOut);
            this.groupBox1.Controls.Add(this.rbBuyIn);
            this.groupBox1.Location = new System.Drawing.Point(33, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action Type";
            // 
            // rbCount
            // 
            this.rbCount.AutoSize = true;
            this.rbCount.Checked = true;
            this.rbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCount.Location = new System.Drawing.Point(16, 72);
            this.rbCount.Name = "rbCount";
            this.rbCount.Size = new System.Drawing.Size(87, 29);
            this.rbCount.TabIndex = 2;
            this.rbCount.Text = "Count";
            this.rbCount.UseVisualStyleBackColor = true;
            // 
            // rbPayOut
            // 
            this.rbPayOut.AutoSize = true;
            this.rbPayOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPayOut.Location = new System.Drawing.Point(163, 19);
            this.rbPayOut.Name = "rbPayOut";
            this.rbPayOut.Size = new System.Drawing.Size(107, 29);
            this.rbPayOut.TabIndex = 1;
            this.rbPayOut.Text = "Pay Out";
            this.rbPayOut.UseVisualStyleBackColor = true;
            // 
            // rbBuyIn
            // 
            this.rbBuyIn.AutoSize = true;
            this.rbBuyIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBuyIn.Location = new System.Drawing.Point(16, 19);
            this.rbBuyIn.Name = "rbBuyIn";
            this.rbBuyIn.Size = new System.Drawing.Size(90, 29);
            this.rbBuyIn.TabIndex = 0;
            this.rbBuyIn.Text = "Buy In";
            this.rbBuyIn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Location = new System.Drawing.Point(33, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(16, 19);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(302, 44);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AMT_Enter);
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.DTP);
            this.gbDate.Location = new System.Drawing.Point(33, 268);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(324, 53);
            this.gbDate.TabIndex = 4;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Date";
            // 
            // DTP
            // 
            this.DTP.CustomFormat = "MM-dd-yyyy HH:mm am/pm";
            this.DTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP.Location = new System.Drawing.Point(16, 19);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(302, 26);
            this.DTP.TabIndex = 4;
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.label3);
            this.gbTime.Controls.Add(this.label2);
            this.gbTime.Controls.Add(this.label1);
            this.gbTime.Controls.Add(this.rbPM);
            this.gbTime.Controls.Add(this.rbAM);
            this.gbTime.Controls.Add(this.SS);
            this.gbTime.Controls.Add(this.MM);
            this.gbTime.Controls.Add(this.HH);
            this.gbTime.Location = new System.Drawing.Point(33, 327);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(324, 69);
            this.gbTime.TabIndex = 5;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Time";
            // 
            // HH
            // 
            this.HH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HH.Location = new System.Drawing.Point(51, 32);
            this.HH.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.HH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HH.Name = "HH";
            this.HH.Size = new System.Drawing.Size(55, 31);
            this.HH.TabIndex = 5;
            this.HH.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // MM
            // 
            this.MM.Cursor = System.Windows.Forms.Cursors.Default;
            this.MM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MM.Location = new System.Drawing.Point(112, 31);
            this.MM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(57, 31);
            this.MM.TabIndex = 6;
            this.MM.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // SS
            // 
            this.SS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SS.Location = new System.Drawing.Point(175, 31);
            this.SS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(57, 31);
            this.SS.TabIndex = 7;
            this.SS.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // rbAM
            // 
            this.rbAM.AutoSize = true;
            this.rbAM.Location = new System.Drawing.Point(259, 23);
            this.rbAM.Name = "rbAM";
            this.rbAM.Size = new System.Drawing.Size(41, 17);
            this.rbAM.TabIndex = 8;
            this.rbAM.TabStop = true;
            this.rbAM.Text = "AM";
            this.rbAM.UseVisualStyleBackColor = true;
            // 
            // rbPM
            // 
            this.rbPM.AutoSize = true;
            this.rbPM.Location = new System.Drawing.Point(259, 46);
            this.rbPM.Name = "rbPM";
            this.rbPM.Size = new System.Drawing.Size(41, 17);
            this.rbPM.TabIndex = 9;
            this.rbPM.TabStop = true;
            this.rbPM.Text = "PM";
            this.rbPM.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "HOUR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "MINUTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SECOND";
            // 
            // rbNothing
            // 
            this.rbNothing.AutoSize = true;
            this.rbNothing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNothing.Location = new System.Drawing.Point(163, 72);
            this.rbNothing.Name = "rbNothing";
            this.rbNothing.Size = new System.Drawing.Size(104, 29);
            this.rbNothing.TabIndex = 3;
            this.rbNothing.Text = "Nothing";
            this.rbNothing.UseVisualStyleBackColor = true;
            // 
            // fmrNewAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 531);
            this.Controls.Add(this.gbTime);
            this.Controls.Add(this.gbDate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmrNewAction";
            this.Text = "New Action";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbDate.ResumeLayout(false);
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAcctNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCount;
        private System.Windows.Forms.RadioButton rbPayOut;
        private System.Windows.Forms.RadioButton rbBuyIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPM;
        private System.Windows.Forms.RadioButton rbAM;
        private System.Windows.Forms.NumericUpDown SS;
        private System.Windows.Forms.NumericUpDown MM;
        private System.Windows.Forms.NumericUpDown HH;
        private System.Windows.Forms.RadioButton rbNothing;
    }
}