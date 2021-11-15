using System.Threading.Tasks;

namespace Core.Services.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email,string subject,string htmlMessage);
    }
}