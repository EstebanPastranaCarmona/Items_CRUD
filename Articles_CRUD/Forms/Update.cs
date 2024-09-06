using Articles_CRUD.Entities;

namespace Articles_CRUD.Forms
{
    /// <summary>
    /// Represents a form for updating an existing item, inheriting from the <see cref="frmCreateItem"/> form.
    /// </summary>
    public partial class frmUpdate : frmCreateItem
    {
        // The item to be updated.
        private Item itemToUpdate;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmUpdate"/> class.
        /// Prepopulates the form fields with the data of the item to be updated.
        /// </summary>
        /// <param name="itemToUpdate">The item object that is being updated.</param>
        public frmUpdate(Item itemToUpdate)
        {
            InitializeComponent();
            this.itemToUpdate = itemToUpdate;

            // Populate the form fields with the current data of the item.
            txtItemMinAmount.Text = itemToUpdate.AmountMinInWarehouse.ToString();
            txtItemMaxAmount.Text = itemToUpdate.AmountMaxInWarehouse.ToString();
        }

        /// <summary>
        /// Handles the click event of the accept button.
        /// Validates and updates the item with the new data provided in the form fields.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public override void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the data from the form fields
                string itemName = txtItemName.Text;
                float itemPrice = GetItemPriceFromGUI();
                int itemAmount = ConvertToStringMaxMinAmount(txtItemAmount.Text);
                string itemCategory = (string)cmbItemCategory.SelectedItem;
                Warehouse itemWarehouse = (Warehouse)cmbWarehouse.SelectedItem;
                int itemMinAmount = ConvertToStringMaxMinAmount(txtItemMinAmount.Text);
                int itemMaxAmount = ConvertToStringMaxMinAmount(txtItemMaxAmount.Text);

                // Update the item with the new data
                itemToUpdate.Update(itemName, itemPrice, itemAmount, itemCategory, itemWarehouse);

                // Close and dispose of the form once the update is successful
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs during the update process
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the form load event.
        /// Populates the warehouse combo box with the available warehouses from the main form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void frmUpdate_Load(object sender, EventArgs e)
        {
            // Cast the owner of this form to the main form to access its data
            frmMain main = Owner as frmMain;
            if (main != null)
            {
                // Set the warehouse combo box data source to the list of warehouses from the main form
                cmbWarehouse.DataSource = main.warehousesList;
            }
        }
    }
}
