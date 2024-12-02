namespace GroupProject7
{
    partial class ReportsForm
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
            this.dtpReportsFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpReportsTo = new System.Windows.Forms.DateTimePicker();
            this.lblReportsFrom = new System.Windows.Forms.Label();
            this.lblReportsTo = new System.Windows.Forms.Label();
            this.btnReportsGenerate = new System.Windows.Forms.Button();
            this.btnReportsClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpReportsFrom
            // 
            this.dtpReportsFrom.Location = new System.Drawing.Point(130, 35);
            this.dtpReportsFrom.Name = "dtpReportsFrom";
            this.dtpReportsFrom.Size = new System.Drawing.Size(185, 20);
            this.dtpReportsFrom.TabIndex = 0;
            // 
            // dtpReportsTo
            // 
            this.dtpReportsTo.Location = new System.Drawing.Point(130, 61);
            this.dtpReportsTo.Name = "dtpReportsTo";
            this.dtpReportsTo.Size = new System.Drawing.Size(185, 20);
            this.dtpReportsTo.TabIndex = 1;
            // 
            // lblReportsFrom
            // 
            this.lblReportsFrom.AutoSize = true;
            this.lblReportsFrom.Location = new System.Drawing.Point(12, 41);
            this.lblReportsFrom.Name = "lblReportsFrom";
            this.lblReportsFrom.Size = new System.Drawing.Size(112, 13);
            this.lblReportsFrom.TabIndex = 2;
            this.lblReportsFrom.Text = "Generate Report From";
            // 
            // lblReportsTo
            // 
            this.lblReportsTo.AutoSize = true;
            this.lblReportsTo.Location = new System.Drawing.Point(12, 67);
            this.lblReportsTo.Name = "lblReportsTo";
            this.lblReportsTo.Size = new System.Drawing.Size(102, 13);
            this.lblReportsTo.TabIndex = 3;
            this.lblReportsTo.Text = "Generate Report To";
            // 
            // btnReportsGenerate
            // 
            this.btnReportsGenerate.Location = new System.Drawing.Point(15, 94);
            this.btnReportsGenerate.Name = "btnReportsGenerate";
            this.btnReportsGenerate.Size = new System.Drawing.Size(136, 23);
            this.btnReportsGenerate.TabIndex = 4;
            this.btnReportsGenerate.Text = "Generate";
            this.btnReportsGenerate.UseVisualStyleBackColor = true;
            this.btnReportsGenerate.Click += new System.EventHandler(this.btnReportsGenerate_Click);
            // 
            // btnReportsClear
            // 
            this.btnReportsClear.Location = new System.Drawing.Point(157, 94);
            this.btnReportsClear.Name = "btnReportsClear";
            this.btnReportsClear.Size = new System.Drawing.Size(136, 23);
            this.btnReportsClear.TabIndex = 5;
            this.btnReportsClear.Text = "Clear";
            this.btnReportsClear.UseVisualStyleBackColor = true;
            this.btnReportsClear.Click += new System.EventHandler(this.btnReportsClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(329, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 154);
            this.Controls.Add(this.btnReportsClear);
            this.Controls.Add(this.btnReportsGenerate);
            this.Controls.Add(this.lblReportsTo);
            this.Controls.Add(this.lblReportsFrom);
            this.Controls.Add(this.dtpReportsTo);
            this.Controls.Add(this.dtpReportsFrom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpReportsFrom;
        private System.Windows.Forms.DateTimePicker dtpReportsTo;
        private System.Windows.Forms.Label lblReportsFrom;
        private System.Windows.Forms.Label lblReportsTo;
        private System.Windows.Forms.Button btnReportsGenerate;
        private System.Windows.Forms.Button btnReportsClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}