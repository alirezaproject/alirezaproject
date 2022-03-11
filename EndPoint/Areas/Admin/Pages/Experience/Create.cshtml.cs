using System.Threading.Tasks;
using Core.DTOs.ResumeAgg.Experience;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Experience
{
    public class CreateModel : PageModel
    {
        #region Constructor

        private readonly IResumeService _resumeService;
        private readonly ISiteService _siteService;

        public CreateModel(IResumeService resumeService, ISiteService siteService)
        {
            _resumeService = resumeService;
            _siteService = siteService;
        }

        #endregion

        [BindProperty]
        public CreateExperienceDto Input { get; set; }

        public async Task OnGet()
        {
            ViewData["Lang"] = await _siteService.GetLanguages();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return RedirectToPage();

            await _resumeService.CreateExperienceAsync(Input);

            return RedirectToPage("./Index");
        }
    }
}
