using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Helper
{
    public class BasePageModel : PageModel
    {
        public  string SuccessMessage = "SuccessMessage";
        public string ErrorMessage = "ErrorMessage";
        public string WarningMessage = "WarningMessage";
        public string InfoMessage = "InfoMessage";
    }
}