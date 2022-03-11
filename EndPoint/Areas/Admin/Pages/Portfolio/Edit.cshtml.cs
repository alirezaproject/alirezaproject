using System.Threading.Tasks;
using Core.DTOs.Portfolio;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Portfolio
{
    public class EditModel : PageModel
    {

        #region

        private readonly IPortfolioService _portfolioService;

        public EditModel(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        #endregion

        [BindProperty]
        public EditPortfolioDto Input { get; set; }

        public async Task OnGet(int portfolioId)
        {
            Input = await _portfolioService.GetPortfoliDetailsAsync(portfolioId);
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return RedirectToPage();

            await _portfolioService.EditPortfolioAsync(Input);

            return RedirectToPage("./Index");
        }
    }
}
