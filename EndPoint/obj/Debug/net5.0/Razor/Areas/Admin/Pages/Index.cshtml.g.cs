#pragma checksum "D:\Alireza\alirezaproject\EndPoint\Areas\Admin\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14610712d853e4917a66b26a406e92c6d79e0852"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_Index), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/Index.cshtml")]
namespace AspNetCore
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
#line 1 "D:\Alireza\alirezaproject\EndPoint\Areas\Admin\Pages\_ViewImports.cshtml"
using EndPoint;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14610712d853e4917a66b26a406e92c6d79e0852", @"/Areas/Admin/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a671e704cf0437955508961c9918cbc14327e4d7", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Alireza\alirezaproject\EndPoint\Areas\Admin\Pages\Index.cshtml"
  
  ViewData["Title"] ="داشبورد";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/AdminAssets/js/scripts/charts/chart-apex.js\"></script>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""app-content content"">
      <div class=""content-overlay""></div>
      <div class=""content-wrapper"">
        <div class=""content-header row"">
        </div>
        <div class=""content-body"">
<section id=""widgets-Statistics"">
  <div class=""row"">
    <div class=""col-12 mt-1 mb-2"">
      <h4>آمار</h4>
      <hr>
    </div>
  </div>
  <div class=""row"">
    <div class=""col-xl-2 col-md-4 col-sm-6"">
      <div class=""card text-center"">
        <div class=""card-content"">
          <div class=""card-body"">
            <div class=""badge-circle badge-circle-lg badge-circle-light-info mx-auto my-1"">
              <i class=""bx bx-edit-alt font-medium-5""></i>
            </div>
            <p class=""text-muted mb-0 line-ellipsis"">پست های جدید</p>
            <h2 class=""mb-0 primary-font"">48</h2>
          </div>
        </div>
      </div>
    </div>
    <div class=""col-xl-2 col-md-4 col-sm-6"">
      <div class=""card text-center"">
        <div class=""card-content"">
          <div ");
            WriteLiteral(@"class=""card-body"">
            <div class=""badge-circle badge-circle-lg badge-circle-light-warning mx-auto my-1"">
              <i class=""bx bx-file font-medium-5""></i>
            </div>
            <p class=""text-muted mb-0 line-ellipsis"">فایل های ضمیمه شده</p>
            <h2 class=""mb-0 primary-font"">17</h2>
          </div>
        </div>
      </div>
    </div>
    <div class=""col-xl-2 col-md-4 col-sm-6"">
      <div class=""card text-center"">
        <div class=""card-content"">
          <div class=""card-body"">
            <div class=""badge-circle badge-circle-lg badge-circle-light-danger mx-auto my-1"">
              <i class=""bx bx-message font-medium-5""></i>
            </div>
            <p class=""text-muted mb-0 line-ellipsis"">دیدگاه‌ها</p>
            <h2 class=""mb-0 primary-font"">29</h2>
          </div>
        </div>
      </div>
    </div>
    <div class=""col-xl-2 col-md-4 col-sm-6"">
      <div class=""card text-center"">
        <div class=""card-content"">
          <div c");
            WriteLiteral(@"lass=""card-body"">
            <div class=""badge-circle badge-circle-lg badge-circle-light-primary mx-auto my-1"">
              <i class=""bx bx-money font-medium-5""></i>
            </div>
            <p class=""text-muted mb-0 line-ellipsis"">فروش‌ها</p>
            <h2 class=""mb-0 primary-font"">72</h2>
          </div>
        </div>
      </div>
    </div>
    <div class=""col-xl-2 col-md-4 col-sm-6"">
      <div class=""card text-center"">
        <div class=""card-content"">
          <div class=""card-body"">
            <div class=""badge-circle badge-circle-lg badge-circle-light-success mx-auto my-1"">
              <i class=""bx bx-purchase-tag font-medium-5""></i>
            </div>
            <p class=""text-muted mb-0 line-ellipsis"">خرید</p>
            <h2 class=""mb-0 primary-font"">65</h2>
          </div>
        </div>
      </div>
    </div>
    <div class=""col-xl-2 col-md-4 col-sm-6"">
      <div class=""card text-center"">
        <div class=""card-content"">
          <div class=""card");
            WriteLiteral(@"-body"">
            <div class=""badge-circle badge-circle-lg badge-circle-light-danger mx-auto my-1"">
              <i class=""bx bx-shopping-bag font-medium-5""></i>
            </div>
            <p class=""text-muted mb-0 line-ellipsis"">سفارش</p>
            <h2 class=""mb-0 primary-font"">40</h2>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>
<section id=""apexchart"">
  <div class=""row"">
    <!-- Line Chart -->
    <div class=""col-lg-6 col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">نمودار خطی</h4>
            </div>
            <div class=""card-content"">
                <div class=""card-body"">
                    <div id=""line-chart""></div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-6 col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">نمودار خطی</h4>
            </div>
   ");
            WriteLiteral(@"         <div class=""card-content"">
                <div class=""card-body"">
                    <div id=""line-chart2""></div>
                </div>
            </div>
        </div>
    </div>
    </div>
  
</section>

        </div>
      </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EndPoint.Areas.Admin.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EndPoint.Areas.Admin.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EndPoint.Areas.Admin.Pages.IndexModel>)PageContext?.ViewData;
        public EndPoint.Areas.Admin.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
