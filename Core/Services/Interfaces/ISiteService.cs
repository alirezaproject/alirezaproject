using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTOs.Site;
using Core.DTOs.Site.Title;

namespace Core.Services.Interfaces
{
    public interface ISiteService
    {
        Task<HomeDto> GetHomeData();

        Task<List<SiteDto>> GetSiteListAsync();
        Task<List<TitleDto>> GetTitleListAsync();
    }
}