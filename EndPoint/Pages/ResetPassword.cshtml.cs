using System.Threading.Tasks;
using DataLayer.Entities.User;
using EndPoint.Helper;
using EndPoint.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Pages
{
    public class ResetPasswordModel : BasePageModel
    {
        #region Constructor

        private readonly UserManager<User> _userManager;

        public ResetPasswordModel(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        #endregion

        [BindProperty] public ResetPasswordViewModel Input { get; set; } = new();

        public IActionResult OnGet(string email)
        {
            if (email == null)
            {
                return NotFound();
            }

            Input.Email = email;
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.FindByEmailAsync(Input.Email);
            var passwordHasher = new PasswordHasher<User>();
            user.PasswordHash = passwordHasher.HashPassword(user, Input.Password);
            await _userManager.UpdateAsync(user);
            TempData[SuccessMessage] = "رمز عبور با موفقیت تغییر یافت";
            return RedirectToPage("Login");
        }
    }
}
