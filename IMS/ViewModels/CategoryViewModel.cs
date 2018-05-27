using System;
using System.Collections.Generic;

namespace IMS.Web.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the name of Category
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of Category
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the products in Category
        /// </summary>
        public virtual ICollection<ProductViewModel> Products { get; set; }

        /// <summary>
        /// Gets or sets the status (active/inactive) of category 
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the date Category was added
        /// </summary>
        public DateTime DateCreated { get; set; }
    }
}