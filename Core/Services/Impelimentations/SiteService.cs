using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DTOs.Site;
using Core.DTOs.Site.Title;
using Core.Services.Interfaces;
using DataLayer.Contexts;
using DataLayer.Entities.SiteAgg;
using Microsoft.EntityFrameworkCore;

namespace Core.Services.Impelimentations
{
    public class SiteService : ISiteService
    {
        #region Constructor

        private readonly DataBaseContext _context;

        public SiteService(DataBaseContext context)
        {
            _context = context;
        }

        #endregion

        public async Task<List<SocialMedia>> GetAll()
        {
            return await _context.SocialMedia.ToListAsync();
        }


        public async Task<HomeDto> GetHomeData()
        {
            return new HomeDto()
            {
                SocialMedias = await _context.SocialMedia.ToListAsync()
            };
        }

        public async Task<List<SiteDto>> GetSiteListAsync()
        {
            return await _context.Sites.Include(x => x.Language).Select(s => new SiteDto()
            {
                SiteId = s.SiteId,
                Title = s.Title,
                Lanugage = s.Language.LangName,
                LogoAddress = s.LogoAddress,
                SongAdress = s.SongAddress,
                BackgroundImageAddress = s.BackgroundAddress
            }).ToListAsync();
        }

        public async Task<List<TitleDto>> GetTitleListAsync()
        {
            return await _context.Titles.Include(x => x.Language).Select(s => new TitleDto()
            {
                Language = s.Language.LangName,
                Name = s.Name,
                TitleId = s.TitleId
            }).ToListAsync();
        }
    }
}