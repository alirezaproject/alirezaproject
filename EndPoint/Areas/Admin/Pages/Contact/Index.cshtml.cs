using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTOs.Contact;
using Core.Services.Interfaces;
using DataLayer.Entities.ContactAgg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Contact
{
    public class IndexModel : PageModel
    {
        #region Constructor

        private readonly IContactService _contactService;

        public IndexModel(IContactService contactService)
        {
            _contactService = contactService;
        }
        #endregion

        public List<ContactUsDto> Input { get; set; }

        public async Task OnGet()
        {
            Input = await _contactService.GetAllContactUsAsync();
        }
    }
}
