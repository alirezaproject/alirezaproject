﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Core.DTOs.Contact;
using Core.DTOs.Portfolio;
using Core.DTOs.Site;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Hosting;

namespace EndPoint.Pages
{
    public class IndexModel : PageModel
    {
        #region Constructor

        private readonly ISiteService _siteService;
        private readonly IContactService _contactService;
        private readonly IPortfolioService _portfolioService;

        public IndexModel(ISiteService siteService, IContactService contactService, IPortfolioService portfolioService)
        {
            _siteService = siteService;
            _contactService = contactService;
            _portfolioService = portfolioService;
        }

        #endregion

        public MainDto Input { get; set; }
        public List<PortfolioDto> PortfolioDtos { get; set; }

        public async Task OnGet()
        {
            Input = await _siteService.GetMainData(CultureInfo.CurrentCulture.Name);
            PortfolioDtos = await _portfolioService.GetAllPortfolioAsync();
        }

        public IActionResult OnGetChangeCulture(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)), new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });
            return Redirect(Request.Headers["Referer"].ToString());
        }

        public async Task<IActionResult> OnPostSend(CreateContactUsDto command)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = true;
                return Redirect("/Index#contact");
            }

            await _contactService.SendMessageByUserAsync(command);

            TempData["Success"] = true;

            return Redirect("/Index#contact");
        }

      
    }
}
