namespace Timely
{
    partial class WorkTaskFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkTaskFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfile = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWorkTask = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            // 
            // txtProfile
            // 
            this.txtProfile.Location = new System.Drawing.Point(12, 25);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.Size = new System.Drawing.Size(248, 20);
            this.txtProfile.TabIndex = 1;
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Location = new System.Drawing.Point(12, 94);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(70, 22);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Work Task";
            // 
            // txtWorkTask
            // 
            this.txtWorkTask.Location = new System.Drawing.Point(12, 68);
            this.txtWorkTask.Name = "txtWorkTask";
            this.txtWorkTask.Size = new System.Drawing.Size(248, 20);
            this.txtWorkTask.TabIndex = 1;
            // 
            // WorkTaskFrm
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 124);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtWorkTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProfile);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkTaskFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile / WorkTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfile;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWorkTask;
    }
}