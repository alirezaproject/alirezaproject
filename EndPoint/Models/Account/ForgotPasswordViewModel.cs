using System.ComponentModel.DataAnnotations;

namespace EndPoint.Models.Account
{
    public class ForgotPasswordViewModel
    {
        [Display(Name = "ایمیل")]
        [EmailAddress(ErrorMessage = "لطفا ایمیل معتبر وارد کنید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Email { get; set; }

    }
}