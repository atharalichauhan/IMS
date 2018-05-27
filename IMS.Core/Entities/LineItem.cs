using IMS.Core.SharedKernel;

namespace IMS.Core.Entities
{
    /// <summary>
    /// Represents a line item in a transaction
    /// </summary>
    public class LineItem : BaseEntity
    {

        /// <summary>
        /// Gets or sets the product foreign key in Line Item
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the sales order foreign key in Line Item
        /// </summary>
        public int? SalesOrderId { get; set; }

        /// <summary>
        /// Gets or sets the purchase order foreign key in Line Item
        /// </summary>
        public int? PurchaseOrderId { get; set; }

        /// <summary>
        /// Gets or sets the quantity in Line Item
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or sets the quantity received in Line Item
        /// </summary>
        public decimal? QuantityReceived { get; set; }

        /// <summary>
        /// Gets or sets the quantity delivered in LineItem
        /// </summary>
        public decimal? QuantityDelivered { get; set; }

        /// <summary>
        /// Gets or sets the unit price in Line Item
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the discount percent in Line Item
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Gets or sets the product in Line Item
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// Gets or sets the sales order in Line Item
        /// </summary>
        public virtual SalesOrder SalesOrder { get; set; }

        /// <summary>
        /// Gets or sets the purchase order in Line Item
        /// </summary>
        public virtual PurchaseOrder PurchaseOrder { get; set; }

    }
}
