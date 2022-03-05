using System.Threading.Tasks;
using Core.DTOs.Title;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Titles
{
    public class CreateModel : PageModel
    {
        #region Constructor

        private readonly ISiteService _siteService;

        public CreateModel(ISiteService siteService)
        {
            _siteService = siteService;
        }

        #endregion

        [BindProperty]
        public CreateTitleDto Input { get; set; }

        public async Task OnGet()
        {
            ViewData["Lang"] = await _siteService.GetLanguages();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return RedirectToPage();

            await _siteService.CreateTitle(Input);
            
            return RedirectToPage("./Index");
        }

    }
}
