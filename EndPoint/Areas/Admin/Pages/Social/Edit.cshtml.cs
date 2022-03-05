using System.Threading.Tasks;
using Core.Services.Interfaces;
using DataLayer.Entities.SiteAgg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Social
{
    public class EditModel : PageModel
    {
        private readonly ISocialMediaService _socialMediaService;

        public EditModel(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        [BindProperty]
        public SocialMedia SocialMedia { get; set; }   

        public async Task OnGet(int id)
        {
            SocialMedia = await _socialMediaService.GetDetails(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            await _socialMediaService.Edit(SocialMedia);


            return RedirectToPage("./Index");
        }
    }
}
