using System.ComponentModel.DataAnnotations;

namespace PersonalWebPageManagementSystem.Presentation.ViewModels
{
    public class ResumeEducationVm
    {
        public Guid Id { get; set; }

        [StringLength(200, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Institution")]
        [Required]
        public string Institution { get; set; }

        [StringLength(200, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Degree")]
        public string Degree { get; set; }

        [StringLength(200, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Field of Study")]
        public string FieldOfStudy { get; set; }

        [Display(Name = "From Date")]
        [Required]
        public DateTime? FromDate { get; set; }

        [Display(Name = "To Date")]
        public DateTime? ToDate { get; set; }
    }
}
