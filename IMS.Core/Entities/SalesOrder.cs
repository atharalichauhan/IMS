using IMS.Core.SharedKernel;
using System;
using System.Collections.Generic;

namespace IMS.Core.Entities
{
    /// <summary>
    /// Represents a Sales Order
    /// </summary>
    public class SalesOrder : BaseEntity
    {
        /// <summary>
        /// Gets or sets the customer foreign key in Sales Order
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the address foreign key in Sales Order
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Gets or sets the tax foreign key in Sales Order
        /// </summary>
        public int TaxId { get; set; }

        /// <summary>
        /// Gets or sets the Order Date in Sales Order
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets the status of Sales Order
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the remark in Sales Order
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets the tax in Sales Order
        /// </summary>
        public virtual Tax Tax { get; set; }

        /// <summary>
        /// Gets or sets the customer in Sales Order
        /// </summary>
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets the address in Sales Order
        /// </summary>
        public virtual Address Address { get; set; }

        /// <summary>
        /// Gets or sets the line items in Sales Order
        /// </summary>
        public virtual ICollection<LineItem> LineItems { get; set; }

    }
}
