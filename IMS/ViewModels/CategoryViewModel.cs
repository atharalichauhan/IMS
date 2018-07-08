using IMS.Core.SharedKernel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IMS.Web.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        /// <summary>
        /// Gets or sets the name of Category
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of Category
        /// </summary>
        [StringLength(200)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the products in Category
        /// </summary>
        public virtual ICollection<ProductViewModel> Products { get; set; }

        /// <summary>
        /// Gets or sets the status (active/inactive) of category 
        /// </summary>
        public bool IsActive { get; set; }

    }
}