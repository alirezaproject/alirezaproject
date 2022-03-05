using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTOs.Site;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Site
{
    public class IndexModel : PageModel
    {
        #region Constructor

        private readonly ISiteService _siteService;

        public IndexModel(ISiteService siteService)
        {
            _siteService = siteService;
        }

        #endregion

        public List<SiteDto> Input { get; set; }

        public async Task OnGet()
        {
            Input = await _siteService.GetSiteListAsync();
        }
    }
}
