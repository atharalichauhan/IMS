using IMS.Core.SharedKernel;

namespace IMS.Core.Entities
{
    /// <summary>
    /// Represents Tax
    /// </summary>
    public class Tax : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name of Tax
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the rate of Tax
        /// </summary>
        public decimal Rate { get; set; }
    }
}
