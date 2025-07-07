using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalWebPageManagementSystem.ViewModels;
using System.ComponentModel.DataAnnotations;
using PersonalWebPageManagementSystem.Models;
using PersonalWebPageManagementSystem.Data;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace PersonalWebPageManagementSystem.Pages
{
    public class BuildResumeModel : PageModel
    {
        public string FullName { get; set; }

        private readonly ILogger<BuildResumeModel> _logger;
         private readonly PersonalWebPageContext _context;

        public BuildResumeModel(ILogger<BuildResumeModel> logger, PersonalWebPageContext context)
        {
            _logger = logger;
            _context = context;
            FullName = "George Bompotas";
            
        }
        #region OnGet
         public void OnGet()
        {
            Input = new ResumeVm();
        }

        public PartialViewResult OnGetExperiencePartial(){
            var empHistory = Input.EmploymentHistory;
             return new PartialViewResult {
                    ViewName = "_EmploymentHistoryPartialTable",
                    ViewData = new ViewDataDictionary<List<ResumeExperienceVm>>(ViewData, empHistory)
                };
        }

        public PartialViewResult OnGetCreateOrEditEmploymentPartial(int id = 0){
            ResumeExperienceVm exp = null;
            if(id == 0){
                exp = new ResumeExperienceVm();
            }else{
                exp = Input.EmploymentHistory[id];
            }

             return new PartialViewResult {
                    ViewName = "_EmploymentHistoryPartial",
                    ViewData = new ViewDataDictionary<ResumeExperienceVm>(ViewData, exp)
                };
        }

        #endregion

        #region OnPost
         public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

           /*  var entry = _context.Add(new Resume { Id = Guid.NewGuid()});
            entry.CurrentValues.SetValues(Input);*/
            await _context.SaveChangesAsync();
            return RedirectToPage("./index"); 
        }

        public PartialViewResult OnPostExperienceCreateOrEdit(int id,ResumeExperienceVm exp){
            if (id == 0){

                Input.EmploymentHistory.Add(exp);
                
            }else{

                Input.EmploymentHistory[id] = exp;
            }
            var empHistory = Input.EmploymentHistory;
            return  new PartialViewResult {
                ViewName = "_EmploymentHistoryPartialTable",
                ViewData = new ViewDataDictionary<List<ResumeExperienceVm>>(ViewData, empHistory)
            };
        }

        #endregion OnPost
         [BindProperty]
        public ResumeVm Input { get; set; }

        public ResumeExperienceVm Experience {get; set;}


       
    }
}
