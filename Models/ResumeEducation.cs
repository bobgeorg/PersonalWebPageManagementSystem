using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebPageManagementSystem.Models
{
    public class ResumeEducation
    {
        public Guid Id { get; set; }

        [Required]
        public string Institution { get; set; }

        [Required]
        public DateTime? FromDate { get; set; }
        
        [Required]
        public DateTime? ToDate { get; set; }
    }
    
}