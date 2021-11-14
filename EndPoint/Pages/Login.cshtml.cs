using System.Security.Claims;
using System.Threading.Tasks;
using DataLayer.Entities.User;
using EndPoint.Helper;
using EndPoint.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Pages
{
    public class LoginModel : BasePageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public LoginModel(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [BindProperty] public LoginViewModel LoginViewModel { get; set; } = new();

        public IActionResult OnGet(string returnUrl = "/")
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("/");
            }

            LoginViewModel.ReturnUrl = returnUrl;
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();
            var user = await _userManager.FindByNameAsync(LoginViewModel.Email);
            if (user == null)
            {
                TempData[ErrorMessage] = "حساب کاربری یافت نشد";
                return Page();
            }
            var res = await _signInManager.PasswordSignInAsync(user, LoginViewModel.Password, LoginViewModel.RememberMe,
                false);

            if (res.Succeeded)
            {
                await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.GivenName, user.UserName));
                TempData[SuccessMessage] = "با موفقیت وارد شدید";
                return Redirect("/Admin");
            }
            TempData[ErrorMessage] = "ایمیل یا رمز عبور وارد شده اشتباه می باشد";
            return Page();
        }

        public async Task<IActionResult> OnGetLogOut()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/");
        }
    }
}
