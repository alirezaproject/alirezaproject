using Microsoft.AspNetCore.Http;

namespace Core.DTOs.Portfolio
{
    public class CreatePortfolioDto
    {
        public string Title { get; set; }
        public string Tag { get; set; }
        public string Url { get; set; }
        public IFormFile Image { get; set; }

    }
}