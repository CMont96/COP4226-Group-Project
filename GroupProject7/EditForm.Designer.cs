namespace GroupProject7
{
    partial class EditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxPubId = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxAdvance = new System.Windows.Forms.TextBox();
            this.textBoxRoyalty = new System.Windows.Forms.TextBox();
            this.textBoxYTDSales = new System.Windows.Forms.TextBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelPubId = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelAdvance = new System.Windows.Forms.Label();
            this.labelRoyalty = new System.Windows.Forms.Label();
            this.labelYTDSales = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxPublishedOn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(46, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Record:";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxId.Location = new System.Drawing.Point(319, 43);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(374, 35);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxTitle.Location = new System.Drawing.Point(31, 117);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(158, 35);
            this.textBoxTitle.TabIndex = 2;
            // 
            // textBoxType
            // 
            this.textBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxType.Location = new System.Drawing.Point(212, 117);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(158, 35);
            this.textBoxType.TabIndex = 3;
            // 
            // textBoxPubId
            // 
            this.textBoxPubId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPubId.Location = new System.Drawing.Point(390, 117);
            this.textBoxPubId.Name = "textBoxPubId";
            this.textBoxPubId.Size = new System.Drawing.Size(158, 35);
            this.textBoxPubId.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPrice.Location = new System.Drawing.Point(568, 117);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(158, 35);
            this.textBoxPrice.TabIndex = 5;
            // 
            // textBoxAdvance
            // 
            this.textBoxAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxAdvance.Location = new System.Drawing.Point(31, 203);
            this.textBoxAdvance.Name = "textBoxAdvance";
            this.textBoxAdvance.Size = new System.Drawing.Size(158, 35);
            this.textBoxAdvance.TabIndex = 6;
            // 
            // textBoxRoyalty
            // 
            this.textBoxRoyalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRoyalty.Location = new System.Drawing.Point(212, 203);
            this.textBoxRoyalty.Name = "textBoxRoyalty";
            this.textBoxRoyalty.Size = new System.Drawing.Size(158, 35);
            this.textBoxRoyalty.TabIndex = 7;
            // 
            // textBoxYTDSales
            // 
            this.textBoxYTDSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxYTDSales.Location = new System.Drawing.Point(390, 203);
            this.textBoxYTDSales.Name = "textBoxYTDSales";
            this.textBoxYTDSales.Size = new System.Drawing.Size(158, 35);
            this.textBoxYTDSales.TabIndex = 8;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNotes.Location = new System.Drawing.Point(31, 288);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(339, 35);
            this.textBoxNotes.TabIndex = 9;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(31, 378);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(130, 54);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(212, 378);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(158, 54);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(31, 159);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(57, 30);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Title";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(208, 159);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(65, 30);
            this.labelType.TabIndex = 13;
            this.labelType.Text = "Type";
            // 
            // labelPubId
            // 
            this.labelPubId.AutoSize = true;
            this.labelPubId.Location = new System.Drawing.Point(386, 159);
            this.labelPubId.Name = "labelPubId";
            this.labelPubId.Size = new System.Drawing.Size(77, 30);
            this.labelPubId.TabIndex = 14;
            this.labelPubId.Text = "PubId";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(564, 159);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(66, 30);
            this.labelPrice.TabIndex = 15;
            this.labelPrice.Text = "Price";
            // 
            // labelAdvance
            // 
            this.labelAdvance.AutoSize = true;
            this.labelAdvance.Location = new System.Drawing.Point(31, 252);
            this.labelAdvance.Name = "labelAdvance";
            this.labelAdvance.Size = new System.Drawing.Size(107, 30);
            this.labelAdvance.TabIndex = 16;
            this.labelAdvance.Text = "Advance";
            // 
            // labelRoyalty
            // 
            this.labelRoyalty.AutoSize = true;
            this.labelRoyalty.Location = new System.Drawing.Point(208, 252);
            this.labelRoyalty.Name = "labelRoyalty";
            this.labelRoyalty.Size = new System.Drawing.Size(92, 30);
            this.labelRoyalty.TabIndex = 17;
            this.labelRoyalty.Text = "Royalty";
            // 
            // labelYTDSales
            // 
            this.labelYTDSales.AutoSize = true;
            this.labelYTDSales.Location = new System.Drawing.Point(386, 252);
            this.labelYTDSales.Name = "labelYTDSales";
            this.labelYTDSales.Size = new System.Drawing.Size(128, 30);
            this.labelYTDSales.TabIndex = 18;
            this.labelYTDSales.Text = "YTD Sales";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(31, 341);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(51, 20);
            this.labelNotes.TabIndex = 19;
            this.labelNotes.Text = "Notes";
            // 
            // textBoxPublishedOn
            // 
            this.textBoxPublishedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPublishedOn.Location = new System.Drawing.Point(387, 288);
            this.textBoxPublishedOn.Name = "textBoxPublishedOn";
            this.textBoxPublishedOn.Size = new System.Drawing.Size(161, 35);
            this.textBoxPublishedOn.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Published On";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPublishedOn);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelYTDSales);
            this.Controls.Add(this.labelRoyalty);
            this.Controls.Add(this.labelAdvance);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelPubId);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.textBoxYTDSales);
            this.Controls.Add(this.textBoxRoyalty);
            this.Controls.Add(this.textBoxAdvance);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxPubId);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxPubId;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxAdvance;
        private System.Windows.Forms.TextBox textBoxRoyalty;
        private System.Windows.Forms.TextBox textBoxYTDSales;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelPubId;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelAdvance;
        private System.Windows.Forms.Label labelRoyalty;
        private System.Windows.Forms.Label labelYTDSales;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxPublishedOn;
        private System.Windows.Forms.Label label2;
    }
}