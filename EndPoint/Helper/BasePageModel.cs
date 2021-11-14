using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Helper
{
    public class BasePageModel : PageModel
    {
        protected string SuccessMessage = "SuccessMessage";
        protected string ErrorMessage = "ErrorMessage";
        protected string WarningMessage = "WarningMessage";
        protected string InfoMessage = "InfoMessage";
    }
}