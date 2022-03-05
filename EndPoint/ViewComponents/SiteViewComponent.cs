using System.Globalization;
using System.Threading.Tasks;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.ViewComponents
{
    public class HomeSectionViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;

        public HomeSectionViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _siteService.GetHomeData(CultureInfo.CurrentCulture.Name);
            return View("HomeSection",model);
        }
    }

    public class AboutSectionViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("AboutSection");
        }
    }

    public class ResumeSectionViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("ResumeSection");
        }
    }
    public class PortfolioSectionViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("PortfolioSection");
        }
    }

    public class ContactSectionViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("ContactSection");
        }
    }
}