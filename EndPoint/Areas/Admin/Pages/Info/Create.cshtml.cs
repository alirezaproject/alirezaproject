using System.Threading.Tasks;
using Core.DTOs.About.Info;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Info
{
    public class CreateModel : PageModel
    {
        #region Constructor

        private readonly IAboutService _aboutService;
        private readonly ISiteService _siteService;
        public CreateModel(IAboutService aboutService, ISiteService siteService)
        {
            _aboutService = aboutService;
            _siteService = siteService;
        }

        #endregion

        [BindProperty]
        public CreateInfoDto Input { get; set; }

        public async Task OnGet()
        {
            ViewData["Lang"] = await _siteService.GetLanguages();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return RedirectToPage();

            await _aboutService.CreateInfoAsync(Input);
            return RedirectToPage("./Index");
        }
    }
}
