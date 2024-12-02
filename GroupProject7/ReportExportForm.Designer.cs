namespace GroupProject7
{
    partial class ReportExportForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ord_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ord_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReportExport = new System.Windows.Forms.Button();
            this.btnReportClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ord_Num,
            this.TitleID,
            this.Title,
            this.Qty,
            this.Ord_Date,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ord_Num
            // 
            this.Ord_Num.HeaderText = "Ord_Num";
            this.Ord_Num.Name = "Ord_Num";
            // 
            // TitleID
            // 
            this.TitleID.HeaderText = "TitleID";
            this.TitleID.Name = "TitleID";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // Ord_Date
            // 
            this.Ord_Date.HeaderText = "Ord_Date";
            this.Ord_Date.Name = "Ord_Date";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // btnReportExport
            // 
            this.btnReportExport.Location = new System.Drawing.Point(227, 216);
            this.btnReportExport.Name = "btnReportExport";
            this.btnReportExport.Size = new System.Drawing.Size(110, 23);
            this.btnReportExport.TabIndex = 1;
            this.btnReportExport.Text = "Export";
            this.btnReportExport.UseVisualStyleBackColor = true;
            this.btnReportExport.Click += new System.EventHandler(this.btnReportExport_Click);
            // 
            // btnReportClose
            // 
            this.btnReportClose.Location = new System.Drawing.Point(343, 216);
            this.btnReportClose.Name = "btnReportClose";
            this.btnReportClose.Size = new System.Drawing.Size(110, 23);
            this.btnReportClose.TabIndex = 2;
            this.btnReportClose.Text = "Close";
            this.btnReportClose.UseVisualStyleBackColor = true;
            this.btnReportClose.Click += new System.EventHandler(this.btnReportClose_Click);
            // 
            // ReportExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 248);
            this.Controls.Add(this.btnReportClose);
            this.Controls.Add(this.btnReportExport);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReportExportForm";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ord_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ord_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnReportExport;
        private System.Windows.Forms.Button btnReportClose;
    }
}