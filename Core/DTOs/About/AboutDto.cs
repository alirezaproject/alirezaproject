using System.Collections.Generic;
using Core.DTOs.About.AboutMe;
using Core.DTOs.About.Favorite;
using Core.DTOs.About.Info;

namespace Core.DTOs.About
{
    public class AboutDto
    {
        public AboutMeDto AboutMeDto { get; set; }
        public List<InfoDto> InfoDtos { get; set; }
        public List<FavoriteDto> FavoriteDtos { get; set; }
    }
}