using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTOs.ResumeAgg.Experience;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EndPoint.Areas.Admin.Pages.Experience
{
    public class IndexModel : PageModel
    {
        #region Constructor

        private readonly IResumeService _resumeService;

        public IndexModel(IResumeService resumeService)
        {
            _resumeService = resumeService;
        }

        #endregion

        public List<ExperienceDto> Input { get; set; }

        public async Task OnGet()
        {
            Input = await _resumeService.GetAllExperienceAsync();
        }
    }
}
