using IMS.Core.SharedKernel;
using System;

namespace IMS.Core.Entities
{
    /// <summary>
    /// Represents a Supplier
    /// </summary>
    public class Supplier : BaseEntity
    {
        /// <summary>
        /// Gets or sets the Address Foreign key in Supplier
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Gets or sets the name of Supplier
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the contact number of Supplier
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Gets or sets the email of Supplier
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the desciption of Supplier
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets status(active/inactive) of Supplier
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the Address in Supplier
        /// </summary>
        public virtual Address Address { get; set; }

    }
}
