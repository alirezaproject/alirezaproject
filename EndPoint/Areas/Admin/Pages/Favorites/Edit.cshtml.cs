using System.Threading.Tasks;
using Core.DTOs.About.Favorite;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Favorites
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
        public EditFavoriteDto Input { get; set; }

        public async Task OnGet(int favoriteId)
        {
            Input = await _aboutService.GetFavoriteDetailsAsync(favoriteId);
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return RedirectToPage();

            await _aboutService.EditFavoriteAsync(Input);

            return RedirectToPage("./Index");
        }
    }
}
