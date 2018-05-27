using IMS.Core.SharedKernel;
using System.Collections.Generic;

namespace IMS.Core.Entities
{
    /// <summary>
    /// Represents a Product
    /// </summary>
    public class Product : BaseEntity
    {
        /// <summary>
        /// Gets or sets the Category Foreign key in Product
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the name of Product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of Product
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the code of Product
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or sets the barcode of Product
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        /// Gets or sets the batch number of Product
        /// </summary>
        public string BatchNumber { get; set; }

        /// <summary>
        /// Gets or sets the avg. cost price of Product
        /// </summary>
        public decimal? AvgCostPrice { get; set; }

        /// <summary>
        /// Gets or sets the avg selling price of Product
        /// </summary>
        public decimal? AvgSellingPrice { get; set; }

        /// <summary>
        /// Gets or sets the Category in Product
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// Gets or sets the Suppliers in Product
        /// </summary>
        public virtual ICollection<Supplier> Suppliers { get; set; }

        /// <summary>
        /// Gets or sets the Manufacturers in Product
        /// </summary>
        public virtual ICollection<Manufacturer> Manufacturers { get; set; }



    }
}
