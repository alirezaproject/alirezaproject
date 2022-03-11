namespace Core.DTOs.ResumeAgg.Experience
{
    public class CreateExperienceDto
    {
        public string Title { get; set; }
        public int Percentage { get; set; }
        public bool IsRight { get; set; }

        public int LanguageId { get;  set; }

    }
}