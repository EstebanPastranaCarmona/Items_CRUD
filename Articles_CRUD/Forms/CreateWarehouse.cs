using Articles_CRUD.Entities;

namespace Articles_CRUD.Forms
{
    /// <summary>
    /// Represents a form for managing warehouses in the application.
    /// </summary>
    public partial class frmCreateWarehouse : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmCreateWarehouse"/> class.
        /// </summary>
        public frmCreateWarehouse()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the Accept button. 
        /// Validates input and creates a new warehouse if the input is valid.
        /// Closes and disposes of the form after successful creation or handles errors.
        /// </summary>
        /// <param name="sender">The source of the event, typically the Accept button.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input values
                string warehouseName = txtWarehouseName.Text;
                string warehouseLocation = Convert.ToString(cmbWarehouseLocation.SelectedItem);

                // Create new warehouse instance
                Warehouse warehouse = new Warehouse(warehouseName, warehouseLocation);

                // Add the new warehouse to the main form's warehouse list
                frmMain main = Owner as frmMain;
                if (main != null)
                {
                    main.warehousesList.Add(warehouse);
                }
                else
                {
                    throw new InvalidOperationException("The owner form is not of type frmMain.");
                }

                // Close and dispose of the form
                this.Close();
                this.Dispose();
            }
            catch (InvalidOperationException ex)
            {
                // Show error message for specific exception
                MessageBox.Show($"Error: {ex.Message}", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                // Show error message for general exceptions
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// handles key press event in Name textbox.
        /// Validates that the text entered does not exceed the size of 20 characters.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> Instance containing the key pressed data</param>
        private void txtWarehouseName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtWarehouseName.Text.Length > 15 && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Warehouse name size is too large","error");
                e.Handled = true;   
            }
        }
    }
}
