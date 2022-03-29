namespace Uni_Books
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.SS = new System.Windows.Forms.StatusStrip();
            this.PB = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.TS = new System.Windows.Forms.ToolStrip();
            this.cmdNew = new System.Windows.Forms.ToolStripButton();
            this.cmdSave = new System.Windows.Forms.ToolStripButton();
            this.cmdSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdExport = new System.Windows.Forms.ToolStripSplitButton();
            this.mnuExport_Bal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExport_All = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdClearAll = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LV_Accounts = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAverage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.cmdRefreshFilter = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.cmdUnfilter = new System.Windows.Forms.Button();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.LV_Activity = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlACCT = new System.Windows.Forms.Panel();
            this.cmdNewAction = new System.Windows.Forms.Button();
            this.lblACCT_Name = new System.Windows.Forms.Label();
            this.lblACCTNumber = new System.Windows.Forms.Label();
            this.SD = new System.Windows.Forms.SaveFileDialog();
            this.TMR = new System.Windows.Forms.Timer(this.components);
            this.SS.SuspendLayout();
            this.TS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlACCT.SuspendLayout();
            this.SuspendLayout();
            // 
            // SS
            // 
            this.SS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PB,
            this.lblStatus,
            this.lblCount,
            this.lblTotal});
            this.SS.Location = new System.Drawing.Point(0, 489);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(891, 24);
            this.SS.TabIndex = 0;
            this.SS.Text = "statusStrip1";
            // 
            // PB
            // 
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(200, 18);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(227)))), ((int)(((byte)(198)))));
            this.lblStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblStatus.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(564, 19);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "Ready";
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(76, 19);
            this.lblCount.Text = "No Accounts";
            // 
            // lblTotal
            // 
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 19);
            this.lblTotal.Text = "$0.00";
            // 
            // TS
            // 
            this.TS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdNew,
            this.cmdSave,
            this.cmdSettings,
            this.toolStripSeparator1,
            this.cmdExport,
            this.cmdClearAll});
            this.TS.Location = new System.Drawing.Point(0, 0);
            this.TS.Name = "TS";
            this.TS.Size = new System.Drawing.Size(891, 25);
            this.TS.TabIndex = 1;
            this.TS.Text = "toolStrip1";
            // 
            // cmdNew
            // 
            this.cmdNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdNew.Image = ((System.Drawing.Image)(resources.GetObject("cmdNew.Image")));
            this.cmdNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(23, 22);
            this.cmdNew.Text = "New Account";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
            this.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(23, 22);
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdSettings
            // 
            this.cmdSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSettings.Image = ((System.Drawing.Image)(resources.GetObject("cmdSettings.Image")));
            this.cmdSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSettings.Name = "cmdSettings";
            this.cmdSettings.Size = new System.Drawing.Size(23, 22);
            this.cmdSettings.Text = "Settings";
            this.cmdSettings.Click += new System.EventHandler(this.cmdSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cmdExport
            // 
            this.cmdExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExport_Bal,
            this.mnuExport_All});
            this.cmdExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdExport.Image")));
            this.cmdExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(32, 22);
            this.cmdExport.Text = "Export Menu";
            // 
            // mnuExport_Bal
            // 
            this.mnuExport_Bal.Image = ((System.Drawing.Image)(resources.GetObject("mnuExport_Bal.Image")));
            this.mnuExport_Bal.Name = "mnuExport_Bal";
            this.mnuExport_Bal.Size = new System.Drawing.Size(157, 22);
            this.mnuExport_Bal.Text = "Export Balances";
            this.mnuExport_Bal.Click += new System.EventHandler(this.mnuExport_Bal_Click);
            // 
            // mnuExport_All
            // 
            this.mnuExport_All.Image = ((System.Drawing.Image)(resources.GetObject("mnuExport_All.Image")));
            this.mnuExport_All.Name = "mnuExport_All";
            this.mnuExport_All.Size = new System.Drawing.Size(157, 22);
            this.mnuExport_All.Text = "Export All Data";
            this.mnuExport_All.Click += new System.EventHandler(this.mnuExport_All_Click);
            // 
            // cmdClearAll
            // 
            this.cmdClearAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdClearAll.Image = ((System.Drawing.Image)(resources.GetObject("cmdClearAll.Image")));
            this.cmdClearAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdClearAll.Name = "cmdClearAll";
            this.cmdClearAll.Size = new System.Drawing.Size(23, 22);
            this.cmdClearAll.Text = "Start Over";
            this.cmdClearAll.Click += new System.EventHandler(this.cmdClearAll_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LV_Accounts);
            this.splitContainer1.Panel1.Controls.Add(this.pnlSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LV_Activity);
            this.splitContainer1.Panel2.Controls.Add(this.pnlACCT);
            this.splitContainer1.Size = new System.Drawing.Size(891, 464);
            this.splitContainer1.SplitterDistance = 403;
            this.splitContainer1.TabIndex = 2;
            // 
            // LV_Accounts
            // 
            this.LV_Accounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.chAverage});
            this.LV_Accounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_Accounts.GridLines = true;
            this.LV_Accounts.HideSelection = false;
            this.LV_Accounts.Location = new System.Drawing.Point(0, 34);
            this.LV_Accounts.Name = "LV_Accounts";
            this.LV_Accounts.Size = new System.Drawing.Size(403, 430);
            this.LV_Accounts.TabIndex = 0;
            this.LV_Accounts.UseCompatibleStateImageBehavior = false;
            this.LV_Accounts.View = System.Windows.Forms.View.Details;
            this.LV_Accounts.SelectedIndexChanged += new System.EventHandler(this.LV_Accounts_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 144;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Balance";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 113;
            // 
            // chAverage
            // 
            this.chAverage.Text = "Average";
            this.chAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chAverage.Width = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.cmdRefreshFilter);
            this.pnlSearch.Controls.Add(this.txtSearchName);
            this.pnlSearch.Controls.Add(this.cmdUnfilter);
            this.pnlSearch.Controls.Add(this.txtSearchID);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(403, 34);
            this.pnlSearch.TabIndex = 1;
            // 
            // cmdRefreshFilter
            // 
            this.cmdRefreshFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdRefreshFilter.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefreshFilter.Image")));
            this.cmdRefreshFilter.Location = new System.Drawing.Point(323, 0);
            this.cmdRefreshFilter.Name = "cmdRefreshFilter";
            this.cmdRefreshFilter.Size = new System.Drawing.Size(40, 34);
            this.cmdRefreshFilter.TabIndex = 3;
            this.cmdRefreshFilter.UseVisualStyleBackColor = true;
            this.cmdRefreshFilter.Click += new System.EventHandler(this.cmdRefreshFilter_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(209)))));
            this.txtSearchName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.Location = new System.Drawing.Point(144, 0);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(144, 26);
            this.txtSearchName.TabIndex = 2;
            // 
            // cmdUnfilter
            // 
            this.cmdUnfilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdUnfilter.Image = ((System.Drawing.Image)(resources.GetObject("cmdUnfilter.Image")));
            this.cmdUnfilter.Location = new System.Drawing.Point(363, 0);
            this.cmdUnfilter.Name = "cmdUnfilter";
            this.cmdUnfilter.Size = new System.Drawing.Size(40, 34);
            this.cmdUnfilter.TabIndex = 1;
            this.cmdUnfilter.UseVisualStyleBackColor = true;
            this.cmdUnfilter.Click += new System.EventHandler(this.cmdUnfilter_Click);
            // 
            // txtSearchID
            // 
            this.txtSearchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(209)))));
            this.txtSearchID.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchID.Location = new System.Drawing.Point(0, 0);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(144, 26);
            this.txtSearchID.TabIndex = 0;
            // 
            // LV_Activity
            // 
            this.LV_Activity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LV_Activity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_Activity.GridLines = true;
            this.LV_Activity.HideSelection = false;
            this.LV_Activity.Location = new System.Drawing.Point(0, 34);
            this.LV_Activity.Name = "LV_Activity";
            this.LV_Activity.Size = new System.Drawing.Size(484, 430);
            this.LV_Activity.TabIndex = 0;
            this.LV_Activity.UseCompatibleStateImageBehavior = false;
            this.LV_Activity.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Action";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 112;
            // 
            // pnlACCT
            // 
            this.pnlACCT.Controls.Add(this.cmdNewAction);
            this.pnlACCT.Controls.Add(this.lblACCT_Name);
            this.pnlACCT.Controls.Add(this.lblACCTNumber);
            this.pnlACCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlACCT.Location = new System.Drawing.Point(0, 0);
            this.pnlACCT.Name = "pnlACCT";
            this.pnlACCT.Size = new System.Drawing.Size(484, 34);
            this.pnlACCT.TabIndex = 1;
            // 
            // cmdNewAction
            // 
            this.cmdNewAction.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdNewAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNewAction.Location = new System.Drawing.Point(443, 0);
            this.cmdNewAction.Name = "cmdNewAction";
            this.cmdNewAction.Size = new System.Drawing.Size(41, 34);
            this.cmdNewAction.TabIndex = 2;
            this.cmdNewAction.Text = "+";
            this.cmdNewAction.UseVisualStyleBackColor = true;
            this.cmdNewAction.Click += new System.EventHandler(this.cmdNewAction_Click);
            // 
            // lblACCT_Name
            // 
            this.lblACCT_Name.AutoSize = true;
            this.lblACCT_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACCT_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblACCT_Name.Location = new System.Drawing.Point(205, 4);
            this.lblACCT_Name.Name = "lblACCT_Name";
            this.lblACCT_Name.Size = new System.Drawing.Size(17, 24);
            this.lblACCT_Name.TabIndex = 1;
            this.lblACCT_Name.Text = "-";
            // 
            // lblACCTNumber
            // 
            this.lblACCTNumber.AutoSize = true;
            this.lblACCTNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACCTNumber.ForeColor = System.Drawing.Color.Teal;
            this.lblACCTNumber.Location = new System.Drawing.Point(4, 4);
            this.lblACCTNumber.Name = "lblACCTNumber";
            this.lblACCTNumber.Size = new System.Drawing.Size(17, 24);
            this.lblACCTNumber.TabIndex = 0;
            this.lblACCTNumber.Text = "-";
            // 
            // TMR
            // 
            this.TMR.Interval = 3600;
            this.TMR.Tick += new System.EventHandler(this.TMR_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 513);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.TS);
            this.Controls.Add(this.SS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Account Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Close);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SS.ResumeLayout(false);
            this.SS.PerformLayout();
            this.TS.ResumeLayout(false);
            this.TS.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlACCT.ResumeLayout(false);
            this.pnlACCT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip SS;
        private System.Windows.Forms.ToolStrip TS;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView LV_Accounts;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView LV_Activity;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel pnlACCT;
        private System.Windows.Forms.Label lblACCT_Name;
        private System.Windows.Forms.Label lblACCTNumber;
        private System.Windows.Forms.ToolStripButton cmdNew;
        private System.Windows.Forms.ToolStripButton cmdSave;
        private System.Windows.Forms.Button cmdNewAction;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.ToolStripStatusLabel lblTotal;
        private System.Windows.Forms.ToolStripButton cmdSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog SD;
        private System.Windows.Forms.ToolStripSplitButton cmdExport;
        private System.Windows.Forms.ToolStripMenuItem mnuExport_Bal;
        private System.Windows.Forms.ToolStripMenuItem mnuExport_All;
        private System.Windows.Forms.Timer TMR;
        private System.Windows.Forms.ToolStripProgressBar PB;
        private System.Windows.Forms.ColumnHeader chAverage;
        private System.Windows.Forms.ToolStripButton cmdClearAll;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button cmdUnfilter;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Button cmdRefreshFilter;
    }
}

