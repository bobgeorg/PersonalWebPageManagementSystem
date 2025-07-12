using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PersonalWebPageManagementSystem.Web.Razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string FullName { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Profession { get; set; } = "";
        public string Description { get; set; } = "";

       
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            FirstName = "George";
            LastName = "Bompotas";
            FullName = FirstName + " " + LastName;
            Profession = ".Net Software Enginner";
            Description = "Code enthusiast, fighting complexity and striving for quality.";
    }

        public void OnGet()
        {

        }
    }
}