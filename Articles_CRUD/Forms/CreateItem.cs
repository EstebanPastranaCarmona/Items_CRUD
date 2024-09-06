using Articles_CRUD.Entities;

namespace Articles_CRUD.Forms
{
    /// <summary>
    /// Represents a form for managing items in the application.
    /// </summary>
    public partial class frmCreateItem : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmCreateItem"/> class.
        /// </summary>
        public frmCreateItem()
        {
            InitializeComponent();
        }

        #region events

        /// <summary>
        /// Handles the Click event of the accept button.
        /// Gathers input data, creates a new item and adds it to the list of items in the main form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = txtItemName.Text;
                float itemPrice = GetItemPriceFromGUI();
                int itemAmount = ConvertToStringMaxMinAmount(txtItemAmount.Text);
                string itemCategory = (string)cmbItemCategory.SelectedItem;
                Warehouse itemWarehouse = (Warehouse)cmbWarehouse.SelectedItem;
                int itemMinAmount = ConvertToStringMaxMinAmount(txtItemMinAmount.Text);
                int itemMaxAmount = ConvertToStringMaxMinAmount(txtItemMaxAmount.Text);

                // Create a new item using the provided input
                Item item = new Item(itemName, itemPrice, itemAmount, itemCategory, itemWarehouse, itemMinAmount, itemMaxAmount);

                // Add the new item to the main form's item list
                frmMain main = Owner as frmMain;
                if (main != null)
                {
                    main.itemsList.Add(item);
                }
                else
                {
                    throw new InvalidOperationException("The owner form is not of type frmMain.");
                }
                this.Close();
                this.Dispose();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Load event of the form.
        /// Initializes the warehouse combobox by loading the list of warehouses from the main form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void frmCreateArticles_Load(object sender, EventArgs e)
        {
            frmMain main = Owner as frmMain;
            if (main != null)
            {
                // Load the list of warehouses into the combobox
                cmbWarehouse.DataSource = main.warehousesList;
            }
        }

        /// <summary>
        /// handles the event for when the text changes in the textBox Price.
        /// Prevents the "," character from being removed from the textBox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"> instance containing the event data. </param>
        private void txtItemPrice_TextChanged(object sender, EventArgs e)
        {
            char protectedChar = ','; // The proctected character 
            string text = txtItemPrice.Text; // Gets the current text from the textbox when it changes

            // The location of the protected character is searched, if it is not there it returns -1
            int protectedIndexChar = text.IndexOf(protectedChar);

            // If the protected character is not in the textbox
            if (protectedIndexChar == -1)
            {
                txtItemPrice.Text = text.Insert(0, protectedChar.ToString()); // It is reinserted into the textbox
                txtItemPrice.SelectionStart = protectedIndexChar + 1; // The cursor changes location
            }
        }

        /// <summary>
        /// Handles the event for when a key is pressed.
        /// Only allows numbers and backspace to be able to be entered in the textbox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"> instance that contains the character that the user pressed. </param>
        private void txtOnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        #endregion events

        #region methods

        /// <summary>
        /// Retrieves the item price from the GUI and converts it to a float.
        /// Throws an exception if the input is not a valid float.
        /// </summary>
        /// <returns>The price of the item as a float.</returns>
        protected float GetItemPriceFromGUI()
        {
            try
            {
                if (float.TryParse(txtItemPrice.Text, out float val))
                {
                    return val;
                }
                else
                {
                    throw new ArithmeticException("The price could not be saved due to a misunderstanding, please retype it");
                }
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Converts a string representing an amount to an integer.
        /// Returns 0 if the input is not a valid integer.
        /// </summary>
        /// <param name="amount">Represent the amount to convert to int.</param>
        /// <returns>The amount as an integer.</returns>
        protected int ConvertToStringMaxMinAmount(string amount)
        {
            try
            {
                if (int.TryParse(amount, out int val))
                {
                    return val;
                }
                else
                {
                    throw new ArithmeticException("The amount could not be saved due to a misunderstanding," +
                                                  " please retype it and make sure it only contains numbers");
                }
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #endregion methods
    }
}

