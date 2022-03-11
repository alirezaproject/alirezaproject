using System.Collections.Generic;
using DataLayer.Entities.AboutAgg;
using DataLayer.Entities.ResumeAgg;
using DataLayer.Entities.SiteAgg;

namespace DataLayer.Entities.Common
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string LangName { get; set; }

        #region Relations

        public ICollection<Site> Sites { get; set; }
        public ICollection<Title> Titles { get; set; }
        public ICollection<AboutMe> AboutMe { get; set; }
        public ICollection<Info> Infos { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Experience> Experiences { get; set; }

        #endregion
    }
}