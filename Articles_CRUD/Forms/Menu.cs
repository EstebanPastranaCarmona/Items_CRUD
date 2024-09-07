using Articles_CRUD.Entities;
using Articles_CRUD.Forms;

namespace Articles_CRUD
{   /// <summary>
    /// Represents a form that manages the application menu.
    /// </summary>
    public partial class frmMain : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmMain"/> class.
        /// Assigns the list of items to bindingSource as dataSource.
        /// Assigns the bindingSource to the datagridview as dataSource.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            ChekIfWarehousesListIsNotEmpty();
            bindingSource.DataSource = itemsList;
            dtgArticles.DataSource = bindingSource;
            dtgArticles.AutoGenerateColumns = true;
            LoadBindingSource(itemsList);
        }

        #region variables
        public List<Warehouse> warehousesList = new List<Warehouse>();
        public List<Item> itemsList = new List<Item>();
        List<Item> filteredItemList = new List<Item>();
        BindingSource bindingSource = new BindingSource();
        bool isFiltered = false;
        #endregion variables

        #region methods

        /// <summary>
        /// Check that the list of warehouses is not empty.
        /// If it is, disable the button to create items.
        /// </summary>
        void ChekIfWarehousesListIsNotEmpty()
        {
            if (warehousesList.Count == 0)
            {
                btnCreateItem.Enabled = false;
            }
            else
            {
                btnCreateItem.Enabled = true;
            }
        }

        /// <summary>
        /// Load the bindingSource reassigning the list of items as dataSource.
        /// </summary>
        void LoadBindingSource(List<Item> list)
        {
            bindingSource.DataSource = list;
            bindingSource.ResetBindings(false);
        }

        /// <summary>
        /// Handles the deletion of an item from the items list at the specified row index.
        /// </summary>
        /// <param name="rowIndex">The index of the row where the delete button was clicked.</param>
        void HandleDeleteButtonClick(Item selectedItem)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the item '{selectedItem.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                itemsList.Remove(selectedItem);
                LoadBindingSource(itemsList);
            }
        }

        /// <summary>
        /// Handles the update of an item by opening the update form.
        /// </summary>
        /// <param name="rowIndex">The index of the row where the update button was clicked.</param>
        void HandleEditButtonClick(Item selectedItem)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to Update the item '{selectedItem.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CallToForm(typeof(frmUpdate), selectedItem);
            }
        }

        /// <summary>
        /// Receives a type of form and creates an instance of that form.
        /// </summary>
        /// <param name="frmType">The type of the form that will be instantiated.</param>
        /// <param name="parameter">the parameter that is passed to the constructor in case it is requested.</param>
        void CallToForm(Type frmType, object parameter = null)
        {
            if (typeof(Form).IsAssignableFrom(frmType))
            {
                Form form;
                if (parameter != null)
                {
                    form = (Form)Activator.CreateInstance(frmType, parameter);
                }
                else
                {
                    form = (Form)Activator.CreateInstance(frmType);
                }

                form.Owner = this;
                form.ShowDialog();
                ChekIfWarehousesListIsNotEmpty();
                LoadBindingSource(itemsList);
            }
        }

        #endregion methods

        #region events

        /// <summary>
        /// Handles the Click event of the createWarehouse button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCreateWarehouse_Click(object sender, EventArgs e)
        {
            CallToForm(typeof(frmCreateWarehouse));
        }

        /// <summary>
        /// Handles the Click event of the createItem button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            CallToForm(typeof(frmCreateItem));
        }

        /// <summary>
        /// Handles the event for when a cell in the dataGridView is clicked.
        /// If the column has the name DeleteItem and is a DataGridButton, 
        /// the method is called to deleted the item from the itemsList.
        /// If the column has the name UpdateItem and is a DataGridButton, the method is called to update the item.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dtgArticles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // It is checked that the row where clicked in the dataGrid exists,
            // and let the clickead column be a datagridview button
            if (e.RowIndex >= 0 && dtgArticles.Columns[e.ColumnIndex] is DataGridViewButtonColumn clickedColumn)
            {
                Item selectedItem;
                if (isFiltered)
                {
                    selectedItem = filteredItemList[e.RowIndex];
                }
                else
                {
                    selectedItem = itemsList[e.RowIndex];
                }

                if (clickedColumn.Name == "DeleteItem")// Checks if the column name is "DeleteItem" 
                {
                    HandleDeleteButtonClick(selectedItem);// The method is called to delete the item
                }
                else if (clickedColumn.Name == "UpdateItem")// Checks if the column name is "UpdateItem"
                {
                    HandleEditButtonClick(selectedItem);// The method is called to update the item
                }
            }
        }

        /// <summary>
        /// Handles the event for when a key is pressed within the txtSearchItem.
        /// If the text size is greater than or equal to 3 characters,
        /// a list will be created that filters all items that begin with those three or more characters.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/>
        /// instance containing the character that was pressed inside the textbox</param>
        private void txtSearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearchItem.Text.Length >= 3)
            {
                filteredItemList = itemsList.Where(x => x.Name.StartsWith(txtSearchItem.Text,
                                                  StringComparison.OrdinalIgnoreCase)).ToList();
                LoadBindingSource(filteredItemList);
                isFiltered = true;
            }
            else
            {
                LoadBindingSource(itemsList);
                isFiltered = false;
            }
        }

        #endregion events
    }
}
