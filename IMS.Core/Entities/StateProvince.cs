﻿using IMS.Core.SharedKernel;

namespace IMS.Core.Entities
{
    /// <summary>
    /// Represents a State/Province
    /// </summary>
    public class StateProvince : BaseEntity
    {
        /// <summary>
        /// Gets or sets country foreign key in StateProvince
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets the name of StateProvince
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the abbreviation of StateProvince
        /// </summary>
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or sets the country in StateProvince
        /// </summary>
        public virtual Country Country { get; set; }

        /// <summary>
        /// Gets or sets the status(active/inactive) of StateProvince
        /// </summary>
        public bool IsActive { get; set; }

    }
}
