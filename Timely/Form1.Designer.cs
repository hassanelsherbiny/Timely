namespace Timely
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WorkTaskLv = new System.Windows.Forms.ListView();
            this.IdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FromCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PeriodCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.CmbProfiles = new System.Windows.Forms.ComboBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnStartPause = new System.Windows.Forms.Button();
            this.AutoSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.CmbTasks = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnMenuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.LblCopyRight = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkTaskLv
            // 
            this.WorkTaskLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdCol,
            this.FromCol,
            this.ToCol,
            this.PeriodCol});
            this.WorkTaskLv.FullRowSelect = true;
            this.WorkTaskLv.GridLines = true;
            this.WorkTaskLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.WorkTaskLv.HideSelection = false;
            this.WorkTaskLv.Location = new System.Drawing.Point(8, 51);
            this.WorkTaskLv.Name = "WorkTaskLv";
            this.WorkTaskLv.Size = new System.Drawing.Size(524, 407);
            this.WorkTaskLv.TabIndex = 1;
            this.WorkTaskLv.UseCompatibleStateImageBehavior = false;
            this.WorkTaskLv.View = System.Windows.Forms.View.Details;
            this.WorkTaskLv.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.WorkTaskLv_ColumnWidthChanging);
            this.WorkTaskLv.SelectedIndexChanged += new System.EventHandler(this.WorkTaskLv_SelectedIndexChanged);
            this.WorkTaskLv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WorkTaskLv_KeyDown);
            // 
            // IdCol
            // 
            this.IdCol.DisplayIndex = 3;
            this.IdCol.Text = "";
            this.IdCol.Width = 1;
            // 
            // FromCol
            // 
            this.FromCol.DisplayIndex = 0;
            this.FromCol.Text = "From";
            this.FromCol.Width = 100;
            // 
            // ToCol
            // 
            this.ToCol.DisplayIndex = 1;
            this.ToCol.Text = "To";
            this.ToCol.Width = 100;
            // 
            // PeriodCol
            // 
            this.PeriodCol.DisplayIndex = 2;
            this.PeriodCol.Text = "Period";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Profile";
            // 
            // CmbProfiles
            // 
            this.CmbProfiles.FormattingEnabled = true;
            this.CmbProfiles.Location = new System.Drawing.Point(8, 25);
            this.CmbProfiles.Name = "CmbProfiles";
            this.CmbProfiles.Size = new System.Drawing.Size(206, 21);
            this.CmbProfiles.TabIndex = 3;
            this.CmbProfiles.SelectedIndexChanged += new System.EventHandler(this.CmbProfiles_SelectedIndexChanged);
            // 
            // BtnNew
            // 
            this.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNew.Location = new System.Drawing.Point(437, 23);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(22, 22);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "+";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnStartPause
            // 
            this.BtnStartPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStartPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStartPause.Location = new System.Drawing.Point(462, 23);
            this.BtnStartPause.Name = "BtnStartPause";
            this.BtnStartPause.Size = new System.Drawing.Size(70, 22);
            this.BtnStartPause.TabIndex = 0;
            this.BtnStartPause.Text = "Start";
            this.BtnStartPause.UseVisualStyleBackColor = true;
            this.BtnStartPause.Click += new System.EventHandler(this.BtnStartPause_Click);
            // 
            // AutoSaveTimer
            // 
            this.AutoSaveTimer.Interval = 60000;
            this.AutoSaveTimer.Tick += new System.EventHandler(this.AutoSaveTimer_Tick);
            // 
            // CmbTasks
            // 
            this.CmbTasks.FormattingEnabled = true;
            this.CmbTasks.Location = new System.Drawing.Point(225, 25);
            this.CmbTasks.Name = "CmbTasks";
            this.CmbTasks.Size = new System.Drawing.Size(206, 21);
            this.CmbTasks.TabIndex = 5;
            this.CmbTasks.SelectedIndexChanged += new System.EventHandler(this.CmbTasks_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Work Task";
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Timely";
            this.TrayIcon.DoubleClick += new System.EventHandler(this.BtnStartPause_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnMenuShow,
            this.BtnMenuExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // BtnMenuShow
            // 
            this.BtnMenuShow.Name = "BtnMenuShow";
            this.BtnMenuShow.Size = new System.Drawing.Size(103, 22);
            this.BtnMenuShow.Text = "Show";
            this.BtnMenuShow.Click += new System.EventHandler(this.BtnMenuShow_Click);
            // 
            // BtnMenuExit
            // 
            this.BtnMenuExit.Name = "BtnMenuExit";
            this.BtnMenuExit.Size = new System.Drawing.Size(103, 22);
            this.BtnMenuExit.Text = "Exit";
            this.BtnMenuExit.Click += new System.EventHandler(this.BtnMenuExit_Click);
            // 
            // LblCopyRight
            // 
            this.LblCopyRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblCopyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCopyRight.Location = new System.Drawing.Point(5, 461);
            this.LblCopyRight.Name = "LblCopyRight";
            this.LblCopyRight.Size = new System.Drawing.Size(527, 25);
            this.LblCopyRight.TabIndex = 6;
            this.LblCopyRight.Text = "© CopyRight Bits Developments 2020 Dev.Hasan Elsherbiny";
            this.LblCopyRight.Click += new System.EventHandler(this.LblCopyRight_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(290, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total : 00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 495);
            this.Controls.Add(this.LblCopyRight);
            this.Controls.Add(this.CmbTasks);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbProfiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WorkTaskLv);
            this.Controls.Add(this.BtnStartPause);
            this.Controls.Add(this.BtnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timely";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView WorkTaskLv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbProfiles;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnStartPause;
        private System.Windows.Forms.ColumnHeader FromCol;
        private System.Windows.Forms.ColumnHeader ToCol;
        private System.Windows.Forms.ColumnHeader PeriodCol;
        private System.Windows.Forms.Timer AutoSaveTimer;
        private System.Windows.Forms.ComboBox CmbTasks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ColumnHeader IdCol;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtnMenuShow;
        private System.Windows.Forms.ToolStripMenuItem BtnMenuExit;
        private System.Windows.Forms.Label LblCopyRight;
        private System.Windows.Forms.Label lblTotal;
    }
}

