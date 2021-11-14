using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;

namespace WebSite.EndPoint.Helpers.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement(Attributes = RouteAttributeName)]
    [HtmlTargetElement(Attributes = ClassAttributeName)]
    [HtmlTargetElement(Attributes = PageAttributeName)]
    public class RazorPageActiveLinkTagHelper : TagHelper
    {
       
        private const string ClassAttributeName = "asp-active-class";
        private const string RouteAttributeName = "asp-active-route";
        private const string PageAttributeName = "asp-active-page";



        [HtmlAttributeName(RouteAttributeName)]
        public string Route { get; set; }

        [HtmlAttributeName(PageAttributeName)]
        public string Page { get; set; }

        [HtmlAttributeName(ClassAttributeName)]
        public string Class { get; set; } = "active";

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            RouteValueDictionary routeValues = ViewContext.RouteData.Values;
            //string currentAction = routeValues["Page"].ToString();
            
            string currentPage = routeValues["Page"].ToString();

           
            if (string.IsNullOrEmpty(Page))
            {
                Page = currentPage;
            }

            string[] acceptedPages = Page.Trim().Split(',').Distinct().ToArray();
            



            //string[] acceptedActions = Actions.Trim().Split(',').Distinct().ToArray();
            //string[] acceptedControllers = Controllers.Trim().Split(',').Distinct().ToArray();
            

            if (acceptedPages.Contains(currentPage))
            {
                SetAttribute(output, "class", Class);
            }


            base.Process(context, output);
        }

        private static void SetAttribute(TagHelperOutput output, string attributeName, string value, bool merge = true)
        {
            var v = value;
            if (output.Attributes.TryGetAttribute(attributeName, out var attribute))
            {
                if (merge)
                {
                    v = $"{attribute.Value} {value}";
                }
            }
            output.Attributes.SetAttribute(attributeName, v);
        }
    }
}
