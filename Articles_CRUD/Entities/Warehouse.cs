using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles_CRUD.Entities
{
    /// <summary>
    /// represents a warehouse where items are stored.
    /// </summary>
    public class Warehouse
    {
        private string name;
        private string location;

        /// <summary>
        /// Gets or sets the name of the warehouse. Must not be empty or null.
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
        /// Gets or sets the location of the warehouse. Must not be empty or null.
        /// </summary>
        public string Location 
        {
            get { return location; } 
            set
            {
                ValidationHelper.ValidateIfValueIsNullOrEmpty(value, nameof(Location));
                location = value;   
            } 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Warehouse"/> class.
        /// </summary>
        /// <param name="name">The name of the warehouse.</param>
        /// <param name="location">the location of the warehouse.</param>
        public Warehouse(string name, string location)
        {
            Name = name;
            Location = location;
        }

        /// <summary>
        /// Method that is called when the class is printed.
        /// </summary>
        /// <returns>Returns the name of the object.</returns>
        public override string ToString()
        {
            return name;
        }
    }
}
