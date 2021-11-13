using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.ViewComponents
{
    public class HomeSectionViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("HomeSection");
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