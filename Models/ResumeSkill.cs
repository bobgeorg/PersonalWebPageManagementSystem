using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebPageManagementSystem.Models
{
    public class ResumeSkill
    {
         public Guid Id { get; set; }
        public Int16 Level { get; set; }
    }
    
}