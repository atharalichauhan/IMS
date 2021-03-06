﻿using IMS.Core.SharedKernel;
using System;
using System.Collections.Generic;

namespace IMS.Core.Entities 
{
    /// <summary>
    /// Represents a Category
    /// </summary>
    public class Category : BaseEntity
    {

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
        public virtual ICollection<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the status (active/inactive) of category 
        /// </summary>
        public bool IsActive { get; set; }
    }
}
