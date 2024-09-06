namespace Articles_CRUD.Forms
{
    partial class frmCreateItem
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
            lblItemName = new Label();
            lblItemPrice = new Label();
            lblItemAmount = new Label();
            lblItemCategory = new Label();
            lblItemWarehouse = new Label();
            lblItemMinAmount = new Label();
            lblItemMaxAmount = new Label();
            txtItemName = new TextBox();
            txtItemPrice = new TextBox();
            txtItemMinAmount = new TextBox();
            txtItemAmount = new TextBox();
            txtItemMaxAmount = new TextBox();
            cmbItemCategory = new ComboBox();
            btnCancel = new Button();
            btnAccept = new Button();
            label8 = new Label();
            cmbWarehouse = new ComboBox();
            SuspendLayout();
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(138, 37);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(52, 20);
            lblItemName.TabIndex = 0;
            lblItemName.Text = "Name:";
            // 
            // lblItemPrice
            // 
            lblItemPrice.AutoSize = true;
            lblItemPrice.Location = new Point(138, 90);
            lblItemPrice.Name = "lblItemPrice";
            lblItemPrice.Size = new Size(44, 20);
            lblItemPrice.TabIndex = 1;
            lblItemPrice.Text = "Price:";
            // 
            // lblItemAmount
            // 
            lblItemAmount.AutoSize = true;
            lblItemAmount.Location = new Point(138, 146);
            lblItemAmount.Name = "lblItemAmount";
            lblItemAmount.Size = new Size(65, 20);
            lblItemAmount.TabIndex = 2;
            lblItemAmount.Text = "Amount:";
            // 
            // lblItemCategory
            // 
            lblItemCategory.AutoSize = true;
            lblItemCategory.Location = new Point(138, 193);
            lblItemCategory.Name = "lblItemCategory";
            lblItemCategory.Size = new Size(72, 20);
            lblItemCategory.TabIndex = 3;
            lblItemCategory.Text = "Category:";
            lblItemCategory.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblItemWarehouse
            // 
            lblItemWarehouse.AutoSize = true;
            lblItemWarehouse.Location = new Point(138, 244);
            lblItemWarehouse.Name = "lblItemWarehouse";
            lblItemWarehouse.Size = new Size(85, 20);
            lblItemWarehouse.TabIndex = 4;
            lblItemWarehouse.Text = "Warehouse:";
            // 
            // lblItemMinAmount
            // 
            lblItemMinAmount.AutoSize = true;
            lblItemMinAmount.Location = new Point(12, 349);
            lblItemMinAmount.Name = "lblItemMinAmount";
            lblItemMinAmount.Size = new Size(94, 20);
            lblItemMinAmount.TabIndex = 5;
            lblItemMinAmount.Text = "Min Amount:\r\n";
            // 
            // lblItemMaxAmount
            // 
            lblItemMaxAmount.AutoSize = true;
            lblItemMaxAmount.Location = new Point(275, 353);
            lblItemMaxAmount.Name = "lblItemMaxAmount";
            lblItemMaxAmount.Size = new Size(97, 20);
            lblItemMaxAmount.TabIndex = 6;
            lblItemMaxAmount.Text = "Max Amount:\r\n";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(247, 37);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(125, 27);
            txtItemName.TabIndex = 7;
            // 
            // txtItemPrice
            // 
            txtItemPrice.Location = new Point(247, 86);
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.Size = new Size(125, 27);
            txtItemPrice.TabIndex = 8;
            txtItemPrice.Text = "0,0";
            txtItemPrice.TextChanged += txtItemPrice_TextChanged;
            txtItemPrice.KeyPress += txtOnlyNumber_KeyPress;
            // 
            // txtItemMinAmount
            // 
            txtItemMinAmount.Location = new Point(126, 346);
            txtItemMinAmount.Name = "txtItemMinAmount";
            txtItemMinAmount.Size = new Size(125, 27);
            txtItemMinAmount.TabIndex = 9;
            txtItemMinAmount.Text = "0";
            txtItemMinAmount.KeyPress += txtOnlyNumber_KeyPress;
            // 
            // txtItemAmount
            // 
            txtItemAmount.Location = new Point(247, 139);
            txtItemAmount.Name = "txtItemAmount";
            txtItemAmount.Size = new Size(125, 27);
            txtItemAmount.TabIndex = 10;
            txtItemAmount.Text = "0";
            txtItemAmount.KeyPress += txtOnlyNumber_KeyPress;
            // 
            // txtItemMaxAmount
            // 
            txtItemMaxAmount.Location = new Point(391, 350);
            txtItemMaxAmount.Name = "txtItemMaxAmount";
            txtItemMaxAmount.Size = new Size(125, 27);
            txtItemMaxAmount.TabIndex = 11;
            txtItemMaxAmount.Text = "0";
            txtItemMaxAmount.KeyPress += txtOnlyNumber_KeyPress;
            // 
            // cmbItemCategory
            // 
            cmbItemCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItemCategory.FormattingEnabled = true;
            cmbItemCategory.Items.AddRange(new object[] { "Food", "Cleaning", "Home", "Pets", "Office" });
            cmbItemCategory.Location = new Point(247, 193);
            cmbItemCategory.Name = "cmbItemCategory";
            cmbItemCategory.Size = new Size(125, 28);
            cmbItemCategory.TabIndex = 12;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(315, 412);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 35);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(105, 412);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(128, 35);
            btnAccept.TabIndex = 14;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(204, 342);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 15;
            // 
            // cmbWarehouse
            // 
            cmbWarehouse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWarehouse.FormattingEnabled = true;
            cmbWarehouse.Location = new Point(247, 244);
            cmbWarehouse.Name = "cmbWarehouse";
            cmbWarehouse.Size = new Size(125, 28);
            cmbWarehouse.TabIndex = 16;
            // 
            // frmCreateItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 472);
            Controls.Add(cmbWarehouse);
            Controls.Add(label8);
            Controls.Add(btnAccept);
            Controls.Add(btnCancel);
            Controls.Add(cmbItemCategory);
            Controls.Add(txtItemMaxAmount);
            Controls.Add(txtItemAmount);
            Controls.Add(txtItemMinAmount);
            Controls.Add(txtItemPrice);
            Controls.Add(txtItemName);
            Controls.Add(lblItemMaxAmount);
            Controls.Add(lblItemMinAmount);
            Controls.Add(lblItemWarehouse);
            Controls.Add(lblItemCategory);
            Controls.Add(lblItemAmount);
            Controls.Add(lblItemPrice);
            Controls.Add(lblItemName);
            MaximizeBox = false;
            Name = "frmCreateItem";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Item";
            Load += frmCreateArticles_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemName;
        private Label lblItemPrice;
        private Label lblItemAmount;
        private Label lblItemCategory;
        private Label lblItemWarehouse;
        private Label label8;
        protected TextBox txtItemName;
        protected TextBox txtItemPrice;
        protected TextBox txtItemMinAmount;
        protected TextBox txtItemAmount;
        protected TextBox txtItemMaxAmount;
        protected ComboBox cmbItemCategory;
        protected ComboBox cmbWarehouse;
        protected Label lblItemMinAmount;
        protected Label lblItemMaxAmount;
        protected Button btnCancel;
        protected Button btnAccept;
    }
}