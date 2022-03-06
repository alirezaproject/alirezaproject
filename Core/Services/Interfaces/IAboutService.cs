using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTOs.About;
using Core.DTOs.About.AboutMe;
using Core.DTOs.About.Favorite;
using Core.DTOs.About.Info;

namespace Core.Services.Interfaces
{
    public interface IAboutService
    {
        Task<List<AboutMeDto>> GetAllAboutMeAsync();
        Task<EditAboutMeDto> GetAboutMeDetailsAsync(int aboutMeId);
        Task EditAboutMeAsync(EditAboutMeDto command);

        // Site
        Task<AboutDto> GetAboutMeByLanguageAsync(string culture);
        
        // Info
        Task<List<InfoDto>> GetAllInfoAsync();
        Task CreateInfoAsync(CreateInfoDto command);
        Task<EditInfoDto> GetInfoDetailsAsync(int infoId);
        Task EditInfoAsync(EditInfoDto command);


        // Favorites

        Task<List<FavoriteDto>> GetAllFavoriteAsync();

        Task<EditFavoriteDto> GetFavoriteDetailsAsync(int favoriteId);
        Task CreateFavoriteAsync(CreateFavoriteDto command);
        Task EditFavoriteAsync(EditFavoriteDto command);
    }
}