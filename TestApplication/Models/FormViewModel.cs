using System.ComponentModel.DataAnnotations;
using TestApplication.Core.CustomAttributes;
using TestApplication.Core.Models;

namespace TestApplication.Models
{
    public class FormViewModel
    {
        [Required(ErrorMessage = "Please enter a sector name.")]
        [StringLength(100, ErrorMessage = "Name length can't be more than 100.")]
        public string? Name { get; set; }

        [BooleanRequired(ErrorMessage = "Please agree to terms.")]
        public bool AgreedToTerms { get; set; }

        [Required(ErrorMessage = "Please select at least one sector.")]
        [Display(Name = "Sectors")]
        public List<int>? SelectedSectors { get; set; }

        public List<SectorModel> Sectors { get; set; } = new List<SectorModel>();
    }
}
