namespace Articles_CRUD.Forms
{
    partial class frmCreateWarehouse
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
            lblWarehouseName = new Label();
            lblWarehouseLocation = new Label();
            txtWarehouseName = new TextBox();
            btnAccept = new Button();
            btnCancel = new Button();
            cmbWarehouseLocation = new ComboBox();
            SuspendLayout();
            // 
            // lblWarehouseName
            // 
            lblWarehouseName.AutoSize = true;
            lblWarehouseName.Location = new Point(53, 54);
            lblWarehouseName.Name = "lblWarehouseName";
            lblWarehouseName.Size = new Size(52, 20);
            lblWarehouseName.TabIndex = 0;
            lblWarehouseName.Text = "Name:";
            // 
            // lblWarehouseLocation
            // 
            lblWarehouseLocation.AutoSize = true;
            lblWarehouseLocation.Location = new Point(53, 126);
            lblWarehouseLocation.Name = "lblWarehouseLocation";
            lblWarehouseLocation.Size = new Size(69, 20);
            lblWarehouseLocation.TabIndex = 1;
            lblWarehouseLocation.Text = "Location:";
            // 
            // txtWarehouseName
            // 
            txtWarehouseName.Location = new Point(172, 47);
            txtWarehouseName.Name = "txtWarehouseName";
            txtWarehouseName.Size = new Size(142, 27);
            txtWarehouseName.TabIndex = 2;
            txtWarehouseName.KeyPress += txtWarehouseName_KeyPress;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(12, 218);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(158, 33);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(199, 218);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(158, 33);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbWarehouseLocation
            // 
            cmbWarehouseLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWarehouseLocation.FormattingEnabled = true;
            cmbWarehouseLocation.Items.AddRange(new object[] { "Internal", "External", "Aisle" });
            cmbWarehouseLocation.Location = new Point(172, 118);
            cmbWarehouseLocation.Name = "cmbWarehouseLocation";
            cmbWarehouseLocation.Size = new Size(142, 28);
            cmbWarehouseLocation.TabIndex = 6;
            // 
            // frmCreateWarehouse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 273);
            Controls.Add(cmbWarehouseLocation);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(txtWarehouseName);
            Controls.Add(lblWarehouseLocation);
            Controls.Add(lblWarehouseName);
            MaximizeBox = false;
            Name = "frmCreateWarehouse";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New WareHouse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWarehouseName;
        private Label lblWarehouseLocation;
        private TextBox txtWarehouseName;
        private Button btnAccept;
        private Button btnCancel;
        private ComboBox cmbWarehouseLocation;
    }
}