using System.Collections.Generic;
using Core.DTOs.Site.Title;
using DataLayer.Entities.SiteAgg;

namespace Core.DTOs.Site
{
    public class HomeDto
    {
        public List<SocialMedia> SocialMedias { get; set; }
        public SiteDto Site { get; set; }
        public List<TitleDto> Titles { get; set; }

    }
}