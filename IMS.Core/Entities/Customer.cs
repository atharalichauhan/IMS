using IMS.Core.SharedKernel;
using System;

namespace IMS.Core.Entities
{
    /// <summary>
    /// Represents a Customer
    /// </summary>
    public class Customer : BaseEntity
    {

        /// <summary>
        /// Gets or sets the Address Foreign key in Customer
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Gets or sets the name of Customer
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the contact number of Customer
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Gets or sets the email of Customer
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the desciption of Customer
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the date Customer is Added
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets status(active/inactive) of Customer
        /// </summary>

        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the Address in Customer
        /// </summary>
        public virtual Address Address { get; set; }
    }
}
