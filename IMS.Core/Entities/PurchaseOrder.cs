using IMS.Core.SharedKernel;
using System;
using System.Collections.Generic;

namespace IMS.Core.Entities
{
    /// <summary>
    /// Represents a Purchase Order
    /// </summary>
    public class PurchaseOrder : BaseEntity
    {
        /// <summary>
        /// Gets or sets the supplier foreign key in Purchase Order
        /// </summary>
        public int SupplierId { get; set; }

        /// <summary>
        /// Gets or sets the tax foreign key in Purchase Order
        /// </summary>
        public int TaxId { get; set; }


        /// <summary>
        /// Gets or sets the remark in Purchase Order
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets the status of Purchase Order
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the supplier in Purchase Order
        /// </summary>
        public virtual Supplier Supplier { get; set; }

        /// <summary>
        /// Gets or sets the tax in Purchase Order
        /// </summary>
        public virtual Tax Tax { get; set; }

        /// <summary>
        /// Gets or sets the line items in Purchase Order
        /// </summary>
        public virtual ICollection<LineItem> LineItems { get; set; }
    }
}
