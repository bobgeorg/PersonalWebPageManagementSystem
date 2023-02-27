using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalWebPageManagementSystem.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace PersonalWebPageManagementSystem.Pages
{
    public class BuildResumeModel : PageModel
    {
        public string FullName { get; set; }

        private readonly ILogger<BuildResumeModel> _logger;

        public BuildResumeModel(ILogger<BuildResumeModel> logger)
        {
            _logger = logger;
            FullName = "George Bompotas";
            Input = new ResumeVm();
            Input.EmploymentHistory = new List<ResumeExperienceVm>()
            {
                new ResumeExperienceVm()
                {
                    JodTitle = "Software Engineer",
                    Employer = "Epsilon Net SA",
                    City = "Athens",
                    FromDate = new DateTime(2021, 9, 1),
                    ToDate = null,
                    Description = "Development of new features and maintenance / enhancement of the existing functionality for the Commercial, Financial and CRM applications of the Pylon ERP."

                }
            };
        }
        [BindProperty]
        public ResumeVm Input { get; set; }
        public void OnGet()
        {
        }


       
    }
}
