using System.Threading.Tasks;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Contact
{
    public class MessageModel : PageModel
    {
        #region Constructor

        private readonly IContactService _contactService;

        public MessageModel(IContactService contactService)
        {
            _contactService = contactService;
        }

        #endregion

        public string Message { get; set; }

        public async Task OnGet(long contactUsId)
        {
            Message = await _contactService.GetContactUsMessageByIdAsync(contactUsId);
        }
    }
}
