using System.ComponentModel.DataAnnotations;

namespace PersonalWebPageManagementSystem.Web.Razor.ViewModels
{
    public class ResumeVm
    {
        public Guid Id { get; set; }

        [StringLength(500, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; }

        public byte[] Image { get; set; }

        [StringLength(100, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [StringLength(100, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Phone(ErrorMessage = "Not a valid phone number.")]
        [Display(Name = "Phone Number")]
        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Country")]
        [Required]
        public string Country { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "City")]
        [Required]
        public string City { get; set; }

        [StringLength(200, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }

        [StringLength(15, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Postal Code")]
        [Required]
        public string PostalCode { get; set; }

        public ResumeProfileVm Profile { get; set; }
        public List<ResumeExperienceVm> EmploymentHistory { get; set; } = new List<ResumeExperienceVm>();
        public List<ResumeEducationVm> Education { get; set; } = new List<ResumeEducationVm>();
        public List<ResumeSkillVm> Skills { get; set; } = new List<ResumeSkillVm>();
    }
}
