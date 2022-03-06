using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DTOs.Site;
using Core.DTOs.Site.Title;
using Core.DTOs.Title;
using Core.Services.Interfaces;
using DataLayer.Contexts;
using DataLayer.Entities.SiteAgg;
using Microsoft.AspNetCore.Mvc.Rendering;
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


        public async Task<HomeDto> GetHomeData(string culture)
        {
            return new HomeDto()
            {
                SocialMedias = await _context.SocialMedia.ToListAsync(),
                Site = await _context.Sites.Include(x => x.Language).Where(x => x.Language.LangName == culture).Select(
                    s => new SiteDto()
                    {
                        BackgroundImageAddress = s.BackgroundAddress,
                        Lanugage = s.Language.LangName,
                        LogoAddress = s.LogoAddress,
                        SiteId = s.SiteId,
                        SongAdress = s.SongAddress,
                        Title = s.Title
                    }).FirstOrDefaultAsync(),
                Titles = await _context.Titles.Include(x => x.Language).Where(x => x.Language.LangName == culture)
                    .Select(s => new TitleDto()
                    {
                        Language = s.Language.LangName,
                        Name = s.Name,
                        TitleId = s.TitleId
                    }).ToListAsync(),
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

        public async Task CreateTitle(CreateTitleDto command)
        {
            var title = new Title(command.Name, command.LanguageId);
            await _context.Titles.AddAsync(title);
            await _context.SaveChangesAsync();
        }

        public async Task<List<SelectListItem>> GetLanguages()
        {
            return await _context.Languages.Select(s => new SelectListItem()
            {
                Text = s.LangName,
                Value = s.LanguageId.ToString()
            }).ToListAsync();
        }

        public async Task<EditTitleDto> GetTitleDetails(long titleId)
        {
            return await _context.Titles
                .Where(x => x.TitleId == titleId)
                .Select(s => new EditTitleDto()
                {
                    LanguageId = s.LanguageId,
                    Name = s.Name,
                    TitleId = s.TitleId
                })
                .FirstOrDefaultAsync();
        }

        public async Task EditTitle(EditTitleDto command)
        {
            var title = await _context.Titles.FindAsync(command.TitleId);

            title.Edit(command.Name, command.LanguageId);
            await _context.SaveChangesAsync();
        }

        public async Task<MainDto> GetMainData(string culture)
        {
            return await _context.Sites.Include(x => x.Language).Where(x => x.Language.LangName == culture).Select(s => new MainDto()
            {
                Logo = s.LogoAddress,
                Sound = s.SongAddress
            }).FirstOrDefaultAsync();
        }

        public async Task<EditSiteDto> GetSitedetails(int siteId)
        {
            return await _context.Sites.Where(x => x.SiteId == siteId).Select(s => new EditSiteDto()
            {
                Title = s.Title,
                SiteId = s.SiteId,

            }).FirstOrDefaultAsync();
        }

        public async Task EditSite(EditSiteDto command)
        {
            var site = await _context.Sites.FindAsync(command.SiteId);
            site.Title = command.Title;

            await _context.SaveChangesAsync();
        }
    }
}