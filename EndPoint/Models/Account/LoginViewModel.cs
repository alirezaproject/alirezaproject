using System.ComponentModel.DataAnnotations;

namespace EndPoint.Models.Account
{
    public class LoginViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [EmailAddress(ErrorMessage = "لطفا ایمیل معتبر وارد کنید")]
        public string Email { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(150, ErrorMessage = "{0}نمیتواند بیشتر از {1} کاراکتر باشد")]
        [MinLength(6, ErrorMessage = "{0}نمیتواند کمتر از {1} کاراکتر باشد")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }

        public bool RememberMe { get; set; }
    }
}