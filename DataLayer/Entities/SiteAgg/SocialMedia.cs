using System.ComponentModel.DataAnnotations;
using DataLayer.Entities.Common;

namespace DataLayer.Entities.SiteAgg
{
    [Auditable]
    public class SocialMedia
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "نام شبکه اجتماعی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Title { get; set; }
        [Display(Name = "لینک")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Url { get; set; }
        [Display(Name = "کلاس بوت استرپ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string CssClass { get; set; }


        public void Edit(string title,string url,string cssClass)
        {
            Title = title;
            Url = url;
            CssClass = cssClass;
        }
    }
}