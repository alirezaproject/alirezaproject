using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTOs.About.AboutMe;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.AboutMe
{
    public class IndexModel : PageModel
    {
        #region Constructor

        private readonly IAboutService _aboutService;

        public IndexModel(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        #endregion

        public List<AboutMeDto> Input { get; set; }

        public async Task OnGet()
        {
            Input = await _aboutService.GetAllAboutMeAsync();
        }
    }
}
