using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DTOs.Portfolio;
using Core.Services.Interfaces;
using DataLayer.Contexts;
using DataLayer.Entities.PortfolioAgg;
using Microsoft.EntityFrameworkCore;

namespace Core.Services.Impelimentations
{
    public class PortfolioService : IPortfolioService
    {
        #region Constructor

        private readonly DataBaseContext _context;
        private readonly IFileUploader _fileUploader;

        public PortfolioService(DataBaseContext context, IFileUploader fileUploader)
        {
            _context = context;
            _fileUploader = fileUploader;
        }

        #endregion

        public async Task<List<PortfolioDto>> GetAllPortfolioAsync()
        {
            return await _context.Portfolios.Select(s => new PortfolioDto()
            {
                Title = s.Title,
                Url = s.Url,
                PortfolioId = s.PortfolioId,
                Tag = s.Tag,
                Image = s.Image
            }).ToListAsync();
        }

        public async Task CreatePortfolioAsync(CreatePortfolioDto command)
        {
            var path = "";

            if (command.Image != null)
            {
                path = _fileUploader.Upload(command.Image, "Images");
            }
            
            var portfolio = new Portfolio(command.Title, command.Tag, command.Url,path);

            await _context.Portfolios.AddAsync(portfolio);
            await _context.SaveChangesAsync();
        }

        public async Task<EditPortfolioDto> GetPortfoliDetailsAsync(int portfolioId)
        {
            return await _context.Portfolios.Where(x => x.PortfolioId == portfolioId).Select(s => new EditPortfolioDto()
            {
                Title = s.Title,
                Url = s.Url,
                PortfolioId = s.PortfolioId,
                Tag = s.Tag
            })
                .FirstOrDefaultAsync();
        }

        public async Task EditPortfolioAsync(EditPortfolioDto command)
        {
            var portfolio = await _context.Portfolios.FindAsync(command.PortfolioId);

            portfolio.Edit(command.Title,command.Tag,command.Url);
            await _context.SaveChangesAsync();
        }
    }
}