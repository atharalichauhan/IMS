using IMS.Core.SharedKernel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace IMS.Web.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {

        /// <summary>
        /// Gets or sets the Category Foreign key in Product
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the name of Product
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of Product
        /// </summary>
        [StringLength(200)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the code of Product
        /// </summary>
        [Required]
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or sets the barcode of Product
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        /// Gets or sets the batch number of Product
        /// </summary>
        public string BatchNumber { get; set; }

        /// <summary>
        /// Gets or sets the avg. cost price of Product
        /// </summary>
        public decimal? AvgCostPrice { get; set; }

        /// <summary>
        /// Gets or sets the avg selling price of Product
        /// </summary>
        public decimal? AvgSellingPrice { get; set; }


        /// <summary>
        ///  Gets or sets the status (active/inactive) of product 
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the Category in Product
        /// </summary>
        public virtual CategoryViewModel Category { get; set; }

        /// <summary>
        /// Gets categories list  
        /// </summary>
        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}
