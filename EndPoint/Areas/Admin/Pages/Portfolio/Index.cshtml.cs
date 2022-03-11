using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTOs.Portfolio;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Portfolio
{
    public class IndexModel : PageModel
    {
        #region Constructor

        private readonly IPortfolioService _portfolioService;

        public IndexModel(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        #endregion
        public List<PortfolioDto> Input { get; set; }
        public async Task OnGet()
        {
            Input = await _portfolioService.GetAllPortfolioAsync();
        }
    }
}
