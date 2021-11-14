using DataLayer.Entities.Common;

namespace DataLayer.Entities.Site
{
    [Auditable]
    public class SocialMedia
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string CssClass { get; set; }

        
    }
}