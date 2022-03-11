using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTOs.Portfolio;

namespace Core.Services.Interfaces
{
    public interface IPortfolioService
    {
        Task<List<PortfolioDto>> GetAllPortfolioAsync();
        Task CreatePortfolioAsync(CreatePortfolioDto command);
        Task<EditPortfolioDto> GetPortfoliDetailsAsync(int portfolioId);
        Task EditPortfolioAsync(EditPortfolioDto command);
    }
}