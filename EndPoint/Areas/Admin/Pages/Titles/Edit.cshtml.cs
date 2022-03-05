using System.Threading.Tasks;
using Core.DTOs.Title;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Titles
{
    public class EditModel : PageModel
    {
        #region Cosntructor

        private readonly ISiteService _siteService;

        public EditModel(ISiteService siteService)
        {
            _siteService = siteService;
        }

        #endregion
        [BindProperty]
        public EditTitleDto Input { get; set; }

        public async Task OnGet(long titleId)
        {
            ViewData["Lang"] = await _siteService.GetLanguages();
            Input = await _siteService.GetTitleDetails(titleId);
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return RedirectToPage();

            await _siteService.EditTitle(Input);

            return RedirectToPage("./Index");
        }
    }
}
