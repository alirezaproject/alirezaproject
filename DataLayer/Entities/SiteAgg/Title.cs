using DataLayer.Entities.Common;

namespace DataLayer.Entities.SiteAgg
{
    
    public class Title
    {
        public int TitleId { get; set; }
        public string Name { get; set; }

        public Title(string name, int languageId)
        {
            Name = name;
            LanguageId = languageId;
        }

        public void Edit(string name, int languageId)
        {
            Name = name;
            LanguageId = languageId;
        }

        #region Relations

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        #endregion
    }
}