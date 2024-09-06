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
            ChekIfWarehousesListIfNotEmpty();
            bindingSource.DataSource = itemsList;
            dtgArticles.DataSource = bindingSource;
            dtgArticles.AutoGenerateColumns = true;
            LoadBindingSource();
        }

        #region variables
        internal List<Warehouse> warehousesList = new List<Warehouse>();
        internal List<Item> itemsList = new List<Item>();
        BindingSource bindingSource = new BindingSource();
        #endregion variables

        #region methods

        /// <summary>
        /// Check that the list of warehouses is not empty.
        /// If it is, disable the button to create items.
        /// </summary>
        void ChekIfWarehousesListIfNotEmpty()
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
        void LoadBindingSource()
        {
            bindingSource.DataSource = itemsList;
            bindingSource.ResetBindings(false);
        }

        /// <summary>
        /// Handles the deletion of an item from the items list at the specified row index.
        /// </summary>
        /// <param name="rowIndex">The index of the row where the delete button was clicked.</param>
        void HandleDeleteButtonClick(int rowIndex)
        {
            Item selectedItem = itemsList[rowIndex];

            DialogResult result = MessageBox.Show($"Are you sure you want to delete the item '{selectedItem.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                itemsList.Remove(selectedItem);
                LoadBindingSource();
            }
        }

        /// <summary>
        /// Handles the update of an item by opening the update form.
        /// </summary>
        /// <param name="rowIndex">The index of the row where the update button was clicked.</param>
        void HandleEditButtonClick(int rowIndex)
        {
            Item selectedItem = itemsList[rowIndex];

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
                ChekIfWarehousesListIfNotEmpty();
                LoadBindingSource();
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
                if (clickedColumn != null)// It is checked that it is not null
                {
                    if (clickedColumn.Name == "DeleteItem")// Checks if the column name is "DeleteItem" 
                    {
                        HandleDeleteButtonClick(e.RowIndex);// The method is called to delete the item
                    }
                    else if (clickedColumn.Name == "UpdateItem")// Checks if the column name is "UpdateItem"
                    {
                        HandleEditButtonClick(e.RowIndex);// The method is called to update the item
                    }
                }
            }
        }

        #endregion events

    }
}
