using DataLayer.Entities.Common;

namespace DataLayer.Entities.AboutAgg
{
    public class Favorite
    {
        public int FavoriteId { get; private set; }
        public string Icon { get; private set; }
        public string Text { get; private set; }

        public Favorite(string icon, string text, int languageId)
        {
            Icon = icon;
            Text = text;
            LanguageId = languageId;
        }

        public void Edit(string icon, string text)
        {
            Icon = icon;
            Text = text;
        }
        #region Language

        public int LanguageId { get; private set; }
        public Language Language { get; private set; } 

        #endregion
    }
}