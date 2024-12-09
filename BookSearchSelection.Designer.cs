namespace GroupProject7
{
    partial class frmBookSearchSelection
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgvSearchItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(242, 262);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(110, 40);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add To Cart";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dgvSearchItems
            // 
            this.dgvSearchItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchItems.Location = new System.Drawing.Point(12, 60);
            this.dgvSearchItems.Name = "dgvSearchItems";
            this.dgvSearchItems.Size = new System.Drawing.Size(612, 196);
            this.dgvSearchItems.TabIndex = 1;
            this.dgvSearchItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchItems_CellContentClick);
            // 
            // frmBookSearchSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 343);
            this.Controls.Add(this.dgvSearchItems);
            this.Controls.Add(this.btnAddItem);
            this.Name = "frmBookSearchSelection";
            this.Text = "BookSearchSelection";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dgvSearchItems;
    }
}
