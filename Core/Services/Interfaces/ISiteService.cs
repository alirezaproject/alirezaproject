using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTOs.Site;
using Core.DTOs.Site.Title;
using Core.DTOs.Title;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Core.Services.Interfaces
{
    public interface ISiteService
    {
        Task<HomeDto> GetHomeData(string culture);
        
        Task<List<SiteDto>> GetSiteListAsync();
        Task<List<TitleDto>> GetTitleListAsync();
        Task CreateTitle(CreateTitleDto command);
        Task<List<SelectListItem>> GetLanguages();
        Task<EditTitleDto> GetTitleDetails(long titleId);
        Task EditTitle(EditTitleDto command);

        Task<MainDto> GetMainData(string culture);
    }
}