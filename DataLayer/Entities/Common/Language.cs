using System.Collections.Generic;
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

        #endregion
    }
}