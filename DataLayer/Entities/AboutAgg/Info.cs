using DataLayer.Entities.Common;

namespace DataLayer.Entities.AboutAgg
{
    public class Info
    {
        public int InfoId { get; private set; }
        public string Icon { get; private set; }
        public string Title { get; private set; }
        public string Text { get; private set; }

        public Info(string icon, string title, string text, int languageId)
        {
            Icon = icon;
            Title = title;
            Text = text;
            LanguageId = languageId;
        }

        public void Edit(string icon, string title, string text)
        {
            Icon = icon;
            Title = title;
            Text = text;
        }

        #region Relation
        public int LanguageId { get; private set; }
        public Language Language { get; private set; }

        #endregion
    }
}