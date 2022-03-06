using System.Threading.Tasks;
using Core.DTOs.About.Info;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Info
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
        public EditInfoDto Input { get; set; }

        public async Task OnGet(int infoId)
        {
            Input = await _aboutService.GetInfoDetailsAsync(infoId);
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return RedirectToPage();

            await _aboutService.EditInfoAsync(Input);

            return RedirectToPage("./Index");
        }
    }
}
