using System.ComponentModel.DataAnnotations;

namespace PersonalWebPageManagementSystem.Presentation.ViewModels
{
    public class ResumeExperienceVm
    {
        public Guid Id { get; set; }

        [StringLength(200, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Job Title")]
        [Required]
        public string JobTitle { get; set; } = "";

        [StringLength(200, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Employer")]
        [Required]
        public string Employer { get; set; } = "";

        [StringLength(100, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "City")]
        [Required]
        public string City { get; set; } = "";

        [Display(Name = "From Date")]
        [Required]
        public DateTime? FromDate { get; set; }

        [Display(Name = "To Date")]
        public DateTime? ToDate { get; set; }
    }
}
