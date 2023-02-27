using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PersonalWebPageManagementSystem.ViewModels
{
    public class ResumeExperienceVm : ResumeBaseVm
    {
        public Guid Id { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Job Title")]
        [Required]
        public string JodTitle { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Employer")]
        [Required]
        public string Employer { get; set; }

        [StringLength(20, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "City")]
        [Required]
        public string City { get; set; }

        [Display(Name = "From Date")]
        [Required]
        public DateTime? FromDate { get; set; }

        [Display(Name = "From Date")]
        [Required]
        public DateTime? ToDate { get; set; }
    }
}
