using System.ComponentModel.DataAnnotations;

namespace Core.DTOs.About.AboutMe
{
    public class EditAboutMeDto
    {
        public int AboutMeId { get; set; }

        [Display(Name = "اسم")]
        [Required]
        public string Title { get; set; }

        [Display(Name = "متن")]
        [Required]
        public string Text { get; set; }

        [Display(Name = "مکان")]
        [Required]
        public string Location { get; set; }

        
    }
}