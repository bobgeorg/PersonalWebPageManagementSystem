using System.ComponentModel.DataAnnotations;

namespace PersonalWebPageManagementSystem.Presentation.ViewModels
{
    public class ResumeProfileVm
    {
        public Guid Id { get; set; }

        [StringLength(200, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Title")]
        [Required]
        public string Title { get; set; } = "";

        [StringLength(1000, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; } = "";
    }
}
