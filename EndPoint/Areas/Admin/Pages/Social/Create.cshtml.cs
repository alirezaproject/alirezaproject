using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataLayer.Entities.SiteAgg;

namespace EndPoint.Areas.Admin.Pages.Social
{
    public class CreateModel : PageModel
    {
        private readonly DataLayer.Contexts.DataBaseContext _context;

        public CreateModel(DataLayer.Contexts.DataBaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SocialMedia SocialMedia { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _context.SocialMedia.AddAsync(SocialMedia);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
