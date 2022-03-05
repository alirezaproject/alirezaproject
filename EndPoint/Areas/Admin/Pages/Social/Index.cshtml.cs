using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Services.Interfaces;
using DataLayer.Entities.SiteAgg;
using EndPoint.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Social
{
    public class IndexModel : PageModel
    {
        #region Constrcutor

      private readonly ISocialMediaService _mediaService;

      public IndexModel(ISocialMediaService mediaService)
      {
          _mediaService = mediaService;
      }

      #endregion
        
        public List<SocialMedia> SocialMedias { get; set; } 

        public  async Task<IActionResult> OnGet()
        {
            SocialMedias = await _mediaService.GetAll();
            return Page();
        }

        public async Task<IActionResult> OnGetDelete(int id)
        {
            await _mediaService.Delete(id);

            TempData[Message.SuccessMessage] = "با موفقیت حذف شد";

            return RedirectToPage();
        }
    }
}
