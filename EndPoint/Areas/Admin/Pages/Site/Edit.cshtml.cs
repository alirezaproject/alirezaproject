using System.Threading.Tasks;
using Core.DTOs.Site;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Site
{
    public class EditModel : PageModel
    {
        #region Constructor

        private readonly ISiteService _siteService;

        public EditModel(ISiteService siteService)
        {
            _siteService = siteService;
        }

        #endregion

        [BindProperty]
        public EditSiteDto Input { get; set; }

        public async Task OnGet(int siteId)
        {
            Input = await _siteService.GetSitedetails(siteId);
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return RedirectToPage();

            await _siteService.EditSite(Input);

            return RedirectToPage("./Index");
        }
    }
}
