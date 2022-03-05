﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Core.DTOs.Site;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;

namespace EndPoint.Pages
{
    public class IndexModel : PageModel
    {
        #region Constructor

        private readonly ISiteService _siteService;

        public IndexModel(ISiteService siteService)
        {
            _siteService = siteService;
        }

        #endregion

        public MainDto Input { get; set; }


        public async Task OnGet()
        {
            Input = await _siteService.GetMainData(CultureInfo.CurrentCulture.Name);
        }

        public IActionResult OnGetChangeCulture(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)), new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
