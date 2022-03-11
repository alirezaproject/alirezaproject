using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTOs.Contact;

namespace Core.Services.Interfaces
{
    public interface IContactService
    {
        Task<List<ContactUsDto>> GetAllContactUsAsync();
        Task<string> GetContactUsMessageByIdAsync(long contactUsId);
        Task SendMessageByUserAsync(CreateContactUsDto command);
    }
}