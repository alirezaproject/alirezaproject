using System.ComponentModel.DataAnnotations;

namespace Core.DTOs.Title
{
    public class CreateTitleDto
    {
        [Display(Name = "نام عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Name { get; set; }
        public int LanguageId { get; set; }
    }
}