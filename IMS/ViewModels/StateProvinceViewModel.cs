using IMS.Core.SharedKernel;
using System.ComponentModel.DataAnnotations;

namespace IMS.ViewModels
{
    public class StateProvinceViewModel : BaseViewModel
    {     
        public int CountryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(3)]
        [Required]
        public string Abbreviation { get; set; }

        public CountryViewModel Country { get; set; }
    }
}