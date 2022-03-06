using System.Threading.Tasks;
using Core.DTOs.About.AboutMe;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.AboutMe
{
    public class EditModel : PageModel
    {
        #region Constructor

        private readonly IAboutService _aboutService;

        public EditModel(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        #endregion

        [BindProperty]
        public EditAboutMeDto Input { get; set; }

        public async Task OnGet(int aboutMeId)
        {
            Input = await _aboutService.GetAboutMeDetailsAsync(aboutMeId);
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return RedirectToPage();

            await _aboutService.EditAboutMeAsync(Input);


            return RedirectToPage("./Index");
        }
    }
}
