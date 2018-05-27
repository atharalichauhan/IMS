using IMS.Core.SharedKernel;
using System;
using System.Collections.Generic;

namespace IMS.Core.Entities
{
    /// <summary>
    /// Represents a Manufacturer
    /// </summary>
    public class Manufacturer : BaseEntity
    {

        /// <summary>
        /// Gets or sets the name of Manufacturer
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of Manufacturer
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the website of Manufacturer
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// Gets or sets the email of Manufacturer
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the contact number of Manufactuter
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Gets or sets the date Manufacturer is added
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the status (active/inactive) of Manufacturer
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the products in Manufacturer
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }
    }
}
