using IMS.Core.SharedKernel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IMS.ViewModels
{
    public class CountryViewModel : BaseViewModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(3)]
        public string Abbreviation { get; set; }

        public virtual ICollection<StateProvinceViewModel> StateProvinces { get; set; }

        public bool IsActive { get; set; }
    }
}