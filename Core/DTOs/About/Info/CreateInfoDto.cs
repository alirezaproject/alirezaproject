using System.ComponentModel.DataAnnotations;

namespace Core.DTOs.About.Info
{
    public class CreateInfoDto
    {
        [Display(Name = "آیکون")]
        [Required]
        public string Icon { get; set; }

        [Display(Name = "عنوان")]
        [Required]
        public string Title { get; set; }

        [Display(Name = "متن")]
        [Required]
        public string Text { get; set; }

        [Display(Name = "زبان")]
        [Required]
        public int LanguageId { get; set; }
        
    }
}