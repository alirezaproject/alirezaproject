#pragma checksum "G:\Projects\.Net Core\AlirezaProject\EndPoint\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bbb7c4397f9c27c50bb678827f762f8345e637a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EndPoint.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace EndPoint.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "G:\Projects\.Net Core\AlirezaProject\EndPoint\Pages\_ViewImports.cshtml"
using EndPoint;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbb7c4397f9c27c50bb678827f762f8345e637a", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07f5946183a7479d6c19b6f41fea23ec96c71a49", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div id=""home"">
    <div id=""about"">
        <div id=""resume"">
            <div id=""portfolio"">
                <div id=""blog"">
                    <div id=""contact"">

                        <div class=""header-mobile"">
                            <a class=""header-toggle""><i class=""fas fa-bars""></i></a>
                            <h2>باها</h2>
                        </div>

                        <!-- Left Block -->
                        <nav class=""header-main"" data-simplebar>

                            <!-- Logo -->
                            <div class=""logo"">
                                <img src=""img/logo.png""");
            BeginWriteAttribute("alt", " alt=\"", 680, "\"", 686, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>

                            <ul>
                                <li data-tooltip=""خانه"" data-position=""top"">
                                    <a href=""#home"" class=""icon-h fas fa-house-damage""></a>
                                </li>
                                <li data-tooltip=""درباره"" data-position=""top"">
                                    <a href=""#about"" class=""icon-a fas fa-user-tie""></a>
                                </li>
                                <li data-tooltip=""رزومه"" data-position=""top"">
                                    <a href=""#resume"" class=""icon-r fas fa-address-book""></a>
                                </li>
                                <li data-tooltip=""نمونه‌کارها"" data-position=""top"">
                                    <a href=""#portfolio"" class=""icon-p fas fa-briefcase""></a>
                                </li>
                                <li data-tooltip=""تماس"" data-position=""bottom"">
                 ");
            WriteLiteral(@"                   <a href=""#contact"" class=""icon-c fas fa-envelope""></a>
                                </li>
                            </ul>

                            <!-- Sound wave -->
                            <a class=""music-bg"">
                                <div class=""lines"">
                                    <span></span>
                                    <span></span>
                                    <span></span>
                                    <span></span>
                                    <span></span>
                                    <span></span>
                                </div>
                                <p> صدا </p>
                            </a>
                        </nav>

                        <!-- Home Section -->
                        ");
#nullable restore
#line 58 "G:\Projects\.Net Core\AlirezaProject\EndPoint\Pages\Index.cshtml"
                   Write(await Component.InvokeAsync("HomeSection"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        <!-- About Section -->\r\n                        ");
#nullable restore
#line 61 "G:\Projects\.Net Core\AlirezaProject\EndPoint\Pages\Index.cshtml"
                   Write(await Component.InvokeAsync("AboutSection"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        <!-- Resume Section -->\r\n                        ");
#nullable restore
#line 64 "G:\Projects\.Net Core\AlirezaProject\EndPoint\Pages\Index.cshtml"
                   Write(await Component.InvokeAsync("ResumeSection"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        <!-- Portfolio Section -->\r\n                        ");
#nullable restore
#line 67 "G:\Projects\.Net Core\AlirezaProject\EndPoint\Pages\Index.cshtml"
                   Write(await Component.InvokeAsync("PortfolioSection"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        <!-- Contact Section -->\r\n                        ");
#nullable restore
#line 70 "G:\Projects\.Net Core\AlirezaProject\EndPoint\Pages\Index.cshtml"
                   Write(await Component.InvokeAsync("ContactSection"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
