using System.ComponentModel.DataAnnotations;

namespace PersonalWebPageManagementSystem.Web.Razor.ViewModels
{
    public class ResumeSkillVm
    {
        public Guid Id { get; set; }

        [StringLength(100, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Skill Title")]
        [Required]
        public string Title { get; set; }

        [StringLength(500, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Range(1, 10, ErrorMessage = "Level must be between 1 and 10")]
        [Display(Name = "Skill Level")]
        [Required]
        public short Level { get; set; }
    }
}
