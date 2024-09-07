namespace Articles_CRUD
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgArticles = new DataGridView();
            UpdateItem = new DataGridViewButtonColumn();
            DeleteItem = new DataGridViewButtonColumn();
            txtSearchItem = new TextBox();
            btnCreateStore = new Button();
            btnCreateItem = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgArticles).BeginInit();
            SuspendLayout();
            // 
            // dtgArticles
            // 
            dtgArticles.ColumnHeadersHeight = 29;
            dtgArticles.Columns.AddRange(new DataGridViewColumn[] { UpdateItem, DeleteItem });
            dtgArticles.Location = new Point(12, 68);
            dtgArticles.Name = "dtgArticles";
            dtgArticles.RowHeadersWidth = 51;
            dtgArticles.Size = new Size(907, 346);
            dtgArticles.TabIndex = 0;
            dtgArticles.CellContentClick += dtgArticles_CellContentClick;
            // 
            // UpdateItem
            // 
            UpdateItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            UpdateItem.HeaderText = "Update";
            UpdateItem.MinimumWidth = 6;
            UpdateItem.Name = "UpdateItem";
            UpdateItem.Resizable = DataGridViewTriState.True;
            UpdateItem.Width = 64;
            // 
            // DeleteItem
            // 
            DeleteItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DeleteItem.FlatStyle = FlatStyle.Popup;
            DeleteItem.HeaderText = "Delete";
            DeleteItem.MinimumWidth = 6;
            DeleteItem.Name = "DeleteItem";
            DeleteItem.Width = 59;
            // 
            // txtSearchItem
            // 
            txtSearchItem.Location = new Point(123, 22);
            txtSearchItem.Name = "txtSearchItem";
            txtSearchItem.Size = new Size(286, 27);
            txtSearchItem.TabIndex = 1;
            txtSearchItem.KeyPress += txtSearchItem_KeyPress;
            // 
            // btnCreateStore
            // 
            btnCreateStore.Location = new Point(486, 12);
            btnCreateStore.Name = "btnCreateStore";
            btnCreateStore.Size = new Size(159, 47);
            btnCreateStore.TabIndex = 2;
            btnCreateStore.Text = "Add Warehouse";
            btnCreateStore.UseVisualStyleBackColor = true;
            btnCreateStore.Click += btnCreateWarehouse_Click;
            // 
            // btnCreateItem
            // 
            btnCreateItem.Location = new Point(651, 12);
            btnCreateItem.Name = "btnCreateItem";
            btnCreateItem.Size = new Size(159, 47);
            btnCreateItem.TabIndex = 3;
            btnCreateItem.Text = "Add Item";
            btnCreateItem.UseVisualStyleBackColor = true;
            btnCreateItem.Click += btnCreateItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 426);
            Controls.Add(btnCreateItem);
            Controls.Add(btnCreateStore);
            Controls.Add(txtSearchItem);
            Controls.Add(dtgArticles);
            MaximizeBox = false;
            Name = "frmMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List of Articles";
            ((System.ComponentModel.ISupportInitialize)dtgArticles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgArticles;
        private TextBox txtSearchItem;
        private Button btnCreateStore;
        private Button btnCreateItem;
        private DataGridViewButtonColumn UpdateItem;
        private DataGridViewButtonColumn DeleteItem;
    }
}
