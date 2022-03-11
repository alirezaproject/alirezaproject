using System.Globalization;
using System.Threading.Tasks;
using Core.DTOs.Contact;
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
        private readonly IAboutService _aboutService;

        public AboutSectionViewComponent(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _aboutService.GetAboutMeByLanguageAsync(CultureInfo.CurrentCulture.Name);
            return View("AboutSection",model);
        }
    }

    public class ResumeSectionViewComponent : ViewComponent
    {
        private readonly IResumeService _resumeService;

        public ResumeSectionViewComponent(IResumeService resumeService)
        {
            _resumeService = resumeService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _resumeService.GetAllExperienceByLanguageAsync(CultureInfo.CurrentCulture.Name);
            return View("ResumeSection",model);
        }
    }
    public class PortfolioSectionViewComponent : ViewComponent
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioSectionViewComponent(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _portfolioService.GetAllPortfolioAsync();
            return View("PortfolioSection",model);
        }
    }

    public class ContactSectionViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("ContactSection",new CreateContactUsDto());
        }
    }
}