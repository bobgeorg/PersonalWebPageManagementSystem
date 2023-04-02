using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebPageManagementSystem.Models
{
    public class ResumeProfile
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
    
}