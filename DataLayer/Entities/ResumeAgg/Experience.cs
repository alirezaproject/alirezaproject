using DataLayer.Entities.Common;

namespace DataLayer.Entities.ResumeAgg
{
    public class Experience
    {
        public int ExperienceId { get; private set; }
        public string Title { get; private set; }
        public int Percentage { get;private set; }
        public bool IsRight { get; private set; }

        public Experience(string title, int percentage, bool isRight, int languageId)
        {
            Title = title;
            Percentage = percentage;
            IsRight = isRight;
            LanguageId = languageId;
        }

        #region Relations

        public int LanguageId { get; private set; }
        public Language Language { get; private set; }

        #endregion

        public void Edit(string title, int percentage, bool isRight)
        {
            Title = title;
            Percentage = percentage;
            IsRight = isRight;
        }
    }
}