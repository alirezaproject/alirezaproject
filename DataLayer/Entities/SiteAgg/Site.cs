using DataLayer.Entities.Common;

namespace DataLayer.Entities.SiteAgg
{
    [Auditable]
    public class Site
    {
        public int SiteId { get;  set; }
        public string LogoAddress { get;  set; }
        public string SongAddress { get;  set; }
        public string Title { get;  set; }
        public string BackgroundAddress { get; set; }

        #region Relations


        public int LanguageId { get;  set; }
        public Language Language { get;  set; }

        #endregion
    }
}