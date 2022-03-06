using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Core.DTOs.Site
{
    public class EditSiteDto
    {
        public int SiteId { get; set; }


        [Display(Name = "عنوان وسط")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Title { get; set; }


    }
}