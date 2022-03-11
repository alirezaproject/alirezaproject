using System.Threading.Tasks;
using Core.DTOs.Portfolio;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Portfolio
{
    public class CreateModel : PageModel
    {
        #region Constructor

        private readonly IPortfolioService _portfolioService;

        public CreateModel(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        #endregion

        [BindProperty]
        public CreatePortfolioDto Input { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return RedirectToPage();

            await _portfolioService.CreatePortfolioAsync(Input);

            return RedirectToPage("./Index");
        }
    }
}
