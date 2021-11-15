using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Core.Services.Interfaces;
using DataLayer.Entities.User;
using EndPoint.Helper;
using EndPoint.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;

namespace EndPoint.Pages
{
    public class ForgotPasswordModel : BasePageModel
    {
        #region Constructor

        private readonly UserManager<User> _userManager;
        private readonly IEmailService _emailService;

        public ForgotPasswordModel(UserManager<User> userManager, IEmailService emailService)
        {
            _userManager = userManager;
            _emailService = emailService;
        }

        #endregion
        [BindProperty]
        public ForgotPasswordViewModel Input { get; set; }
        public IActionResult OnGet()
        {
            return User.Identity.IsAuthenticated ? Redirect("/") : Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            var user = await _userManager.FindByNameAsync(Input.Email);
            if (user == null)
            {
                TempData[ErrorMessage] = "کاربری یافت نشد";
                return Page();
            }

            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

            var link = Url.PageLink("ForgotPassword", "ConfirmEmail", new { userId = user.Id, code = code }, protocol: HttpContext.Request.Scheme);

            //string url = $"https://localhost:44358/Forgot-Password?Handler=ConfirmEmail&userId=" + user.Id + "&code=" + code;


            await _emailService.SendEmailAsync(Input.Email, "Reset Password",
                $"Please confirm your account by <a href='{link}'>clicking here</a>.");

            TempData[SuccessMessage] = "ایمیل با موفقیت ارسال شد";
            return RedirectToPage("Login");
        }

        public async Task<IActionResult> OnGetConfirmEmail(int userId, string code)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
            {
                return NotFound();
            }
            var codeDecodedBytes = WebEncoders.Base64UrlDecode(code);
            var codeDecoded = Encoding.UTF8.GetString(codeDecodedBytes);

            var res = await _userManager.ConfirmEmailAsync(user, codeDecoded);

            if (!res.Succeeded) return NotFound();
            TempData[SuccessMessage] = "حساب شما یافت شد";
            TempData[InfoMessage] = "میتوانید رمز خود را تغییر دهید";
            return RedirectToPage("ResetPassword", new {email=user.Email});

        }
    }
}
