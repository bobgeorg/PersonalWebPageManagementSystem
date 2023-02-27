using static PersonalWebPageManagementSystem.Pages.BuildResumeModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PersonalWebPageManagementSystem.ViewModels
{
    public class ResumeVm
    {
        public Guid Id { get; set; }

        [StringLength(100, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Wanted Job Title")]
        [Required]
        public string RoleDescription { get; set; }

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
        public string Country { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "City")]
        public string City { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [StringLength(15, ErrorMessage = "Maximum length is {1}")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public ResumeProfileVm Profile { get; set; }
        public List<ResumeExperienceVm> EmploymentHistory { get; set; }
        public List<ResumeEducationVm> Education { get; set; }
        public List<ResumeSkillVm> Skills { get; set; }



    }
}
