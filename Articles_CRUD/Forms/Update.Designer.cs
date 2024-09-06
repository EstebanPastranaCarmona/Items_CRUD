namespace Articles_CRUD.Forms
{
    partial class frmUpdate
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
            SuspendLayout();
            // 
            // txtItemMinAmount
            // 
            txtItemMinAmount.Cursor = Cursors.No;
            txtItemMinAmount.Location = new Point(124, 311);
            txtItemMinAmount.ReadOnly = true;
            // 
            // txtItemMaxAmount
            // 
            txtItemMaxAmount.Cursor = Cursors.No;
            txtItemMaxAmount.Location = new Point(393, 315);
            txtItemMaxAmount.ReadOnly = true;
            // 
            // lblItemMinAmount
            // 
            lblItemMinAmount.Location = new Point(10, 314);
            // 
            // lblItemMaxAmount
            // 
            lblItemMaxAmount.Location = new Point(273, 318);
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(316, 366);
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(106, 366);
            // 
            // frmUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 435);
            Name = "frmUpdate";
            Text = "Update";
            Load += frmUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}