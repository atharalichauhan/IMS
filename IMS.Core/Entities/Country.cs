using IMS.Core.SharedKernel;
using System;
using System.Collections.Generic;

namespace IMS.Core.Entities
{
    /// <summary>
    /// Represents a Country
    /// </summary>
    public class Country : BaseEntity
    {

        /// <summary>
        /// Gets or sets the name of Country
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the abbreviation of Country
        /// </summary>
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or sets the state/provinces
        /// </summary>
        public virtual ICollection<StateProvince> StateProvinces { get; set; }

        /// <summary>
        /// Gets or sets the date country is added
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the status(active/inactive) of Country
        /// </summary>
        public bool IsActive { get; set; }
    }
}
