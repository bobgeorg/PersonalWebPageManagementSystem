using PersonalWebPageManagementSystem.ViewModels;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebPageManagementSystem.Models
{
    public class Resume
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public byte[] Image { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PostalCode { get; set; }
        public ResumeProfile Profile { get; set; }
        public List<ResumeExperience> EmploymentHistory { get; set; }
        public List<ResumeEducation> Education { get; set; }
        public List<ResumeSkill> Skills { get; set; }


    }  
    
}