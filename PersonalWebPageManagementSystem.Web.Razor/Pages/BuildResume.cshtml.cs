using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PersonalWebPageManagementSystem.Application.Services;
using PersonalWebPageManagementSystem.Web.Razor.Mappers;
using PersonalWebPageManagementSystem.Web.Razor.ViewModels;

namespace PersonalWebPageManagementSystem.Web.Razor.Pages
{
    public class BuildResumeModel : PageModel
    {
        private readonly ILogger<BuildResumeModel> _logger;
        private readonly IResumeService _resumeService;

        public BuildResumeModel(ILogger<BuildResumeModel> logger, IResumeService resumeService)
        {
            _logger = logger;
            _resumeService = resumeService;
        }

        [BindProperty]
        public ResumeVm Input { get; set; } = new();

        public ResumeExperienceVm Experience { get; set; } = new();

        #region OnGet
        public async Task OnGetAsync(Guid? id = null)
        {
            if (id.HasValue)
            {
                // Edit existing resume
                var resumeDto = await _resumeService.GetResumeByIdAsync(id.Value);
                Input = ResumeMapper.ToViewModel(resumeDto);
            }
            else
            {
                // Create new resume
                Input = new ResumeVm();
            }
        }

        public PartialViewResult OnGetExperiencePartial()
        {
            var empHistory = Input?.EmploymentHistory ?? new List<ResumeExperienceVm>();
            return new PartialViewResult
            {
                ViewName = "_EmploymentHistoryPartialTable",
                ViewData = new ViewDataDictionary<List<ResumeExperienceVm>>(ViewData, empHistory)
            };
        }

        public PartialViewResult OnGetCreateOrEditEmploymentPartial(int id = 0)
        {
            ResumeExperienceVm exp;
            if (id == 0)
            {
                exp = new ResumeExperienceVm();
            }
            else
            {
                exp = Input?.EmploymentHistory?.ElementAtOrDefault(id) ?? new ResumeExperienceVm();
            }

            return new PartialViewResult
            {
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

            try
            {
                var resumeDto = ResumeMapper.ToDto(Input);
                
                if (Input.Id == Guid.Empty)
                {
                    // Create new resume
                    resumeDto.Id = Guid.NewGuid();
                    await _resumeService.CreateResumeAsync(resumeDto);
                }
                else
                {
                    // Update existing resume
                    await _resumeService.UpdateResumeAsync(resumeDto);
                }

                return RedirectToPage("./Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error saving resume");
                ModelState.AddModelError("", "An error occurred while saving the resume.");
                return Page();
            }
        }

        public PartialViewResult OnPostExperienceCreateOrEdit(int id, ResumeExperienceVm exp)
        {
            if (Input?.EmploymentHistory == null)
            {
                Input = new ResumeVm();
            }

            if (id == 0)
            {
                exp.Id = Guid.NewGuid();
                Input.EmploymentHistory.Add(exp);
            }
            else if (id < Input.EmploymentHistory.Count)
            {
                Input.EmploymentHistory[id] = exp;
            }

            var empHistory = Input.EmploymentHistory;
            return new PartialViewResult
            {
                ViewName = "_EmploymentHistoryPartialTable",
                ViewData = new ViewDataDictionary<List<ResumeExperienceVm>>(ViewData, empHistory)
            };
        }

        public PartialViewResult OnPostDeleteExperience(int id)
        {
            if (Input?.EmploymentHistory != null && id >= 0 && id < Input.EmploymentHistory.Count)
            {
                Input.EmploymentHistory.RemoveAt(id);
            }

            var empHistory = Input?.EmploymentHistory ?? new List<ResumeExperienceVm>();
            return new PartialViewResult
            {
                ViewName = "_EmploymentHistoryPartialTable",
                ViewData = new ViewDataDictionary<List<ResumeExperienceVm>>(ViewData, empHistory)
            };
        }
        #endregion
    }
}
