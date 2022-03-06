using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DTOs.About;
using Core.DTOs.About.AboutMe;
using Core.DTOs.About.Favorite;
using Core.DTOs.About.Info;
using Core.Services.Interfaces;
using DataLayer.Contexts;
using DataLayer.Entities.AboutAgg;
using Microsoft.EntityFrameworkCore;

namespace Core.Services.Impelimentations
{
    public class AboutService : IAboutService
    {
        #region Constructor

        private readonly DataBaseContext _context;

        public AboutService(DataBaseContext context)
        {
            _context = context;
        }

        #endregion

        public async Task<List<AboutMeDto>> GetAllAboutMeAsync()
        {
            return await _context.AboutMe.Select(s => new AboutMeDto()
            {
                Title = s.Title,
                AboutMeId = s.AboutMeId,
                ImageAddress = s.ImageAddress,
                Location = s.Location,
                Resume = s.Resume,
                Text = s.Text,
            }).ToListAsync();
        }

        public async Task<EditAboutMeDto> GetAboutMeDetailsAsync(int aboutMeId)
        {
            return await _context.AboutMe.Where(x => x.AboutMeId == aboutMeId).Select(s => new EditAboutMeDto()
            {
                Title = s.Title,
                Location = s.Location,
                AboutMeId = s.AboutMeId,
                Text = s.Text
            }).FirstOrDefaultAsync();
        }

        public async Task EditAboutMeAsync(EditAboutMeDto command)
        {
            var aboutme = await _context.AboutMe.FindAsync(command.AboutMeId);

            aboutme.Edit(command.Title, command.Text, command.Location);
            await _context.SaveChangesAsync();
        }

        public async Task<AboutDto> GetAboutMeByLanguageAsync(string culture)
        {
            return new AboutDto()
            {
                AboutMeDto =
                    await _context.AboutMe
                        .Include(x => x.Language)
                        .Where(x => x.Language.LangName == culture)
                        .Select(s => new AboutMeDto()
                        {
                            Title = s.Title,
                            Location = s.Location,
                            AboutMeId = s.AboutMeId,
                            Resume = s.Resume,
                            ImageAddress = s.ImageAddress,
                            Text = s.Text
                        })
                        .FirstOrDefaultAsync(),
                InfoDtos = await _context.Info.Include(x => x.Language).Where(x => x.Language.LangName == culture).Select(s => new InfoDto()
                {
                    Title = s.Title,
                    Text = s.Text,
                    Icon = s.Icon,
                    InfoId = s.InfoId
                }).ToListAsync(),
                FavoriteDtos = await _context.Favorites.Include(x => x.Language).Where(x => x.Language.LangName == culture).Select(s => new FavoriteDto()
                {
                    Language = s.Language.LangName,
                    Text = s.Text,
                    Icon = s.Icon,
                    FavoriteId = s.FavoriteId
                }).ToListAsync()
            };
        }

        public async Task<List<InfoDto>> GetAllInfoAsync()
        {
            return await _context.Info.Select(s => new InfoDto()
            {
                Title = s.Title,
                Text = s.Text,
                Language = s.Language.LangName,
                Icon = s.Icon,
                InfoId = s.InfoId,
            }).ToListAsync();
        }

        public async Task CreateInfoAsync(CreateInfoDto command)
        {
            var info = new Info(command.Icon,command.Title,command.Text,command.LanguageId);

            await _context.Info.AddAsync(info);
            await _context.SaveChangesAsync();
        }

        public async Task<EditInfoDto> GetInfoDetailsAsync(int infoId)
        {
            return await _context.Info.Include(x => x.Language).Where(x => x.InfoId == infoId).Select(s => new EditInfoDto()
            {
                Title = s.Title,
                Text = s.Text,
                Icon = s.Icon,
                InfoId = s.InfoId
            }).FirstOrDefaultAsync();
        }

        public async Task EditInfoAsync(EditInfoDto command)
        {
            var info = await _context.Info.FindAsync(command.InfoId);

            info.Edit(command.Icon,command.Title,command.Text);
            await _context.SaveChangesAsync();
        }

        public async Task<List<FavoriteDto>> GetAllFavoriteAsync()
        {
            return await _context.Favorites.Include(x => x.Language).Select(s => new FavoriteDto()
            {
                Language = s.Language.LangName,
                Text = s.Text,
                Icon = s.Icon,
                FavoriteId = s.FavoriteId
            }).ToListAsync();
        }

        public async Task<EditFavoriteDto> GetFavoriteDetailsAsync(int favoriteId)
        {
            return await _context.Favorites.Where(x => x.FavoriteId == favoriteId).Select(s => new EditFavoriteDto()
            {
                Text = s.Text,
                Icon = s.Icon,
                LanguageId = s.LanguageId,
                FavoriteId = s.FavoriteId
            }).FirstOrDefaultAsync();
        }

        public async Task CreateFavoriteAsync(CreateFavoriteDto command)
        {
            var favorite = new Favorite(command.Icon,command.Text,command.LanguageId);
            await _context.Favorites.AddAsync(favorite);
            await _context.SaveChangesAsync();
        }

        public async Task EditFavoriteAsync(EditFavoriteDto command)
        {
            var favorite = await _context.Favorites.FindAsync(command.FavoriteId);
            favorite.Edit(command.Icon,command.Text);
            await _context.SaveChangesAsync();
        }
    }
}