using System.ComponentModel.DataAnnotations;

namespace Core.DTOs.Title
{
    public class EditTitleDto
    {
        public int TitleId { get; set; }

        [Display(Name = "نام عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Name { get; set; }
        public int LanguageId { get; set; }
    }
}