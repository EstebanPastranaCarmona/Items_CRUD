namespace Articles_CRUD.Entities
{
    /// <summary>
    /// Represents an item from a store.
    /// </summary>
    public class Item
    {
        private string name;
        private float price;
        private int amount;
        private string category;
        private Warehouse werehouse;
        private int amountMinInWarehouse;
        private int amountMaxInWarehouse;

        /// <summary>
        /// Gets or sets the item name. Must not be null or empty.
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                ValidationHelper.ValidateIfValueIsNullOrEmpty(value, nameof(Name));
                name = value;
            }
        }

        /// <summary>
        /// Gets or sets the price of the item. Must be non-negative.
        /// </summary>
        public float Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Price), "The price cannot be less than zero.");
                }
                price = value;
            }
        }

        /// <summary>
        /// Gets or sets the quantity of the item in the warehouse. 
        /// Must be within the range defined by AmountMinInWarehouse and AmountMaxInWarehouse.
        /// </summary>
        public int Amount
        {
            get { return amount; }
            set
            {
                if (value < AmountMinInWarehouse || value > AmountMaxInWarehouse)
                {
                    throw new ArgumentOutOfRangeException(nameof(Amount), $"The amount must be between {amountMinInWarehouse} and {amountMaxInWarehouse}.");
                }
                amount = value;
            }
        }

        /// <summary>
        /// Gets or sets the category of the item. Must not be null or empty.
        /// </summary>
        public string Category
        {
            get { return category; }
            set
            {
                ValidationHelper.ValidateIfValueIsNullOrEmpty(value, nameof(Category));
                category = value;
            }
        }

        /// <summary>
        /// Gets or sets the warehouse in which the item is stored. Must not be null.
        /// </summary>
       public Warehouse Werehouse
       {
            get { return werehouse; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(Werehouse), "You have to choose an available warehouse.");
                }
                werehouse = value;
            }
       }

        /// <summary>
        /// Gets or sets the minimum quantity that can be stored for the item. 
        /// Must be non-negative and less than AmountMaxInWarehouse.
        /// </summary>
        public int AmountMinInWarehouse
        {
            get { return amountMinInWarehouse; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Amount Min", "The minimum quantity cannot be negative or zero.");
                }
                amountMinInWarehouse = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximum quantity that can be stored for the item. Must be greater than AmountMinInWarehouse.
        /// </summary>
        public int AmountMaxInWarehouse
        {
            get { return amountMaxInWarehouse; }
            set
            {
                if (value <= amountMinInWarehouse)
                {
                    throw new ArgumentOutOfRangeException("Amount Max", "The minimum quantity cannot be greater or equal than the maximum quantity.");
                }
                amountMaxInWarehouse = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="name">The name of the item.</param>
        /// <param name="price">The price of the item.</param>
        /// <param name="amount">The quantity of the item in the warehouse.</param>
        /// <param name="category">The category of the item.</param>
        /// <param name="werehouse">The warehouse where the item is stored.</param>
        /// <param name="amountMinInWarehouse">The minimum quantity that can be stored for the item.</param>
        /// <param name="amountMaxInWarehouse">The maximum quantity that can be stored for the item.</param>
        public Item(string name, float price, int amount, string category, Warehouse werehouse,
            int amountMinInWarehouse, int amountMaxInWarehouse)
        {
            Name = name;
            Price = price;
            Category = category;
            Werehouse = werehouse;
            AmountMinInWarehouse = amountMinInWarehouse;
            AmountMaxInWarehouse = amountMaxInWarehouse;
            Amount = amount;
        }

        /// <summary>
        /// Method used to update the object.
        /// </summary>
        /// <param name="newName">The new name of the item.</param>
        /// <param name="newPrice">The new price of the item.</param>
        /// <param name="newAmount">The new quantity of the item.</param>
        /// <param name="newCategory">The new category of the item.</param>
        /// <param name="newWerehouse">The new warehouse were the item is stored.</param>
        public void Update(string newName, float newPrice, int newAmount, string newCategory, Warehouse newWerehouse)
        {
            Name = newName;
            Price = newPrice;
            Category = newCategory;
            Werehouse = newWerehouse;
            Amount = newAmount;
        }
    }
}
