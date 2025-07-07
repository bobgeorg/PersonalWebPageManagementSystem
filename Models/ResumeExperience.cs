using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebPageManagementSystem.Models
{
    public class ResumeExperience
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string JodTitle { get; set; }

        [Required]
        public string Employer { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public DateTime? FromDate { get; set; }

        [Required]
        public DateTime? ToDate { get; set; }
    }
    
}