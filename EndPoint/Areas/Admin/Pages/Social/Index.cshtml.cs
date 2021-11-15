using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Social
{
    public class IndexModel : PageModel
    {
        public  async Task<IActionResult> OnGet()
        {
            return Page();
        }
    }
}
