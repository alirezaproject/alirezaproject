
using DataLayer.Entities.Common;

namespace DataLayer.Entities.AboutAgg
{
    
    public class AboutMe
    {
        public int AboutMeId { get; private set; }

        public string Title { get; private set; }
        public string Location { get; private set; }
        public string Text { get; private set; }
        public string Resume { get; private set; }
        public string ImageAddress { get; private set; }

        #region Relations

        public int LanguageId { get; private set; }
        public Language Language { get; private set; }

        #endregion

        public void Edit(string title,string text,string location)
        {
            Title = title;
            Text = text;
            Location = location;
        }
    }
}