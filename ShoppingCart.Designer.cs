namespace GroupProject7
{
    partial class frmShoppingCart
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
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblOrderInformation = new System.Windows.Forms.Label();
            this.txtSearchItems = new System.Windows.Forms.TextBox();
            this.mnuShoppingCart = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnSearchEnter = new System.Windows.Forms.Button();
            this.dgvShoppingCart = new System.Windows.Forms.DataGridView();
            this.mnuShoppingCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoppingCart)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(159, 76);
            this.txtOrderNumber.Multiline = true;
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.ReadOnly = true;
            this.txtOrderNumber.Size = new System.Drawing.Size(250, 25);
            this.txtOrderNumber.TabIndex = 0;
            this.txtOrderNumber.TextChanged += new System.EventHandler(this.txtOrderNumber_TextChanged);
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(50, 77);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(103, 17);
            this.lblOrderNumber.TabIndex = 1;
            this.lblOrderNumber.Text = "Order Number:";
            // 
            // lblOrderInformation
            // 
            this.lblOrderInformation.AutoSize = true;
            this.lblOrderInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderInformation.Location = new System.Drawing.Point(37, 31);
            this.lblOrderInformation.Name = "lblOrderInformation";
            this.lblOrderInformation.Size = new System.Drawing.Size(187, 25);
            this.lblOrderInformation.TabIndex = 2;
            this.lblOrderInformation.Text = "Order Information:";
            // 
            // txtSearchItems
            // 
            this.txtSearchItems.AccessibleDescription = "Search ";
            this.txtSearchItems.Location = new System.Drawing.Point(524, 27);
            this.txtSearchItems.Name = "txtSearchItems";
            this.txtSearchItems.Size = new System.Drawing.Size(100, 20);
            this.txtSearchItems.TabIndex = 3;
            // 
            // mnuShoppingCart
            // 
            this.mnuShoppingCart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuShoppingCart.Location = new System.Drawing.Point(0, 0);
            this.mnuShoppingCart.Name = "mnuShoppingCart";
            this.mnuShoppingCart.Size = new System.Drawing.Size(624, 24);
            this.mnuShoppingCart.TabIndex = 4;
            this.mnuShoppingCart.Text = "menuStrip1";
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
            // btnRemoveItem
            // 
            this.btnRemoveItem.AutoEllipsis = true;
            this.btnRemoveItem.Location = new System.Drawing.Point(122, 381);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(90, 44);
            this.btnRemoveItem.TabIndex = 5;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(249, 381);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 44);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(70, 301);
            this.txtSubTotal.Multiline = true;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 16);
            this.txtSubTotal.TabIndex = 7;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(12, 301);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(52, 13);
            this.lblSubTotal.TabIndex = 8;
            this.lblSubTotal.Text = "Subtotal: ";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(33, 323);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(31, 13);
            this.lblTax.TabIndex = 10;
            this.lblTax.Text = "Tax: ";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(70, 323);
            this.txtTax.Multiline = true;
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 16);
            this.txtTax.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(33, 345);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total: ";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(70, 345);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 16);
            this.txtTotal.TabIndex = 11;
            // 
            // btnSearchEnter
            // 
            this.btnSearchEnter.Location = new System.Drawing.Point(549, 53);
            this.btnSearchEnter.Name = "btnSearchEnter";
            this.btnSearchEnter.Size = new System.Drawing.Size(75, 23);
            this.btnSearchEnter.TabIndex = 21;
            this.btnSearchEnter.Text = "Search";
            this.btnSearchEnter.UseVisualStyleBackColor = true;
            this.btnSearchEnter.Click += new System.EventHandler(this.btnSearchEnter_Click);
            // 
            // dgvShoppingCart
            // 
            this.dgvShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShoppingCart.Location = new System.Drawing.Point(36, 116);
            this.dgvShoppingCart.Name = "dgvShoppingCart";
            this.dgvShoppingCart.Size = new System.Drawing.Size(373, 150);
            this.dgvShoppingCart.TabIndex = 22;
            // 
            // frmShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 437);
            this.Controls.Add(this.dgvShoppingCart);
            this.Controls.Add(this.btnSearchEnter);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.txtSearchItems);
            this.Controls.Add(this.lblOrderInformation);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.mnuShoppingCart);
            this.MainMenuStrip = this.mnuShoppingCart;
            this.Name = "frmShoppingCart";
            this.Text = "Shopping Cart";
            this.mnuShoppingCart.ResumeLayout(false);
            this.mnuShoppingCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoppingCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblOrderInformation;
        private System.Windows.Forms.TextBox txtSearchItems;
        private System.Windows.Forms.MenuStrip mnuShoppingCart;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnSearchEnter;
        private System.Windows.Forms.DataGridView dgvShoppingCart;
    }
}
