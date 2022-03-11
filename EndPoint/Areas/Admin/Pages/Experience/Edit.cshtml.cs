using System.Threading.Tasks;
using Core.DTOs.ResumeAgg.Experience;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Experience
{
    public class EditModel : PageModel
    {
        #region Constructor

        private readonly IResumeService _resumeService;

        public EditModel(IResumeService resumeService)
        {
            _resumeService = resumeService;
        }

        #endregion

        [BindProperty]
        public EditExperienceDto Input { get; set; }

        public async Task OnGet(int experienceId)
        {
            Input = await _resumeService.GetExperienceDetailsAsync(experienceId);
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return RedirectToPage();

            await _resumeService.EditExperienceDetailsAsync(Input);

            return RedirectToPage("./Index");
        }
    }
}
