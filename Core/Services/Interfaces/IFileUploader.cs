using Microsoft.AspNetCore.Http;

namespace Core.Services.Interfaces
{
    public interface IFileUploader
    {
        string Upload(IFormFile file, string path);
    }
}