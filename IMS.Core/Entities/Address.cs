using IMS.Core.SharedKernel;
using System;

namespace IMS.Core.Entities

{
    /// <summary>
    /// Represents an Address
    /// </summary>
    public class Address : BaseEntity
    {
        /// <summary>
        /// Gets or sets StateProvince foreign key in Address
        /// </summary>
        public int? StateProvinceId { get; set; }

        /// <summary>
        /// Gets or sets Country foreign key in Address
        /// </summary>
        public int? CountryId { get; set; }

        /// <summary>
        /// Gets or sets Address Line 1
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets Address Line 2
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets city in Address
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets zip/postal code in Address
        /// </summary>
        public string ZipPostalCode { get; set; }

        /// <summary>
        /// Gets or sets state/province in Address
        /// </summary>
        public virtual StateProvince StateProvince { get; set; }

        /// <summary>
        /// Gets or sets country in Address
        /// </summary>
        public virtual Country Country { get; set; }


    }
}
