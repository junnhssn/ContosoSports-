#pragma checksum "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3dcb4dd5d8b1f79ed7a5f633918d1f472e08eb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Index), @"mvc.1.0.view", @"/Views/Store/Index.cshtml")]
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
#line 1 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\_ViewImports.cshtml"
using Contoso.Apps.SportsLeague.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\_ViewImports.cshtml"
using Contoso.Apps.SportsLeague.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3dcb4dd5d8b1f79ed7a5f633918d1f472e08eb4", @"/Views/Store/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bf66ee1a5764bfdb85279aa9e375802bdc3af75", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contoso.Apps.SportsLeague.Web.Models.StoreIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("HeaderOverlay", async() => {
                WriteLiteral("\r\n    <div class=\"button-wrapper\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <a href=\"#\" class=\"btn-content\">Contoso Store</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            WriteLiteral("\r\n<!-- start of gallery -->\r\n<section class=\"gallery-page-wrapper events\">\r\n    <div class=\"container\">\r\n        <ul class=\"menu-wrapper\" id=\"menu\">\r\n            <li><a href=\"#menu\" data-filter=\"*\" class=\"headline-lato selected\">select all</a></li>\r\n");
#nullable restore
#line 22 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
             foreach (var category in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a href=\"#menu\" data-filter=\".");
#nullable restore
#line 24 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
                                             Write(category.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"headline-lato\">");
#nullable restore
#line 24 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
                                                                                         Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 25 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n        <div class=\"row\">\r\n            <div class=\"wrapper isp-wrap\">\r\n                <div class=\"clearfix\" id=\"list-item\">\r\n");
#nullable restore
#line 30 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
                     foreach (var product in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 1062, "\"", 1096, 2);
            WriteAttributeValue("", 1070, "figure", 1070, 6, true);
#nullable restore
#line 32 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
WriteAttributeValue(" ", 1076, product.CategoryID, 1077, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"item clearfix\">\r\n                                <a class=\"item-img\"");
            BeginWriteAttribute("href", " href=\"", 1208, "\"", 1278, 1);
#nullable restore
#line 34 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
WriteAttributeValue("", 1215, Url.Action("Details", "Store", new { id = product.ProductID }), 1215, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1322, "\"", 1380, 2);
#nullable restore
#line 35 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
WriteAttributeValue("", 1328, Url.Content("~/Images/Products/"), 1328, 34, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
WriteAttributeValue("", 1362, product.ImagePath, 1362, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1381, "\"", 1407, 1);
#nullable restore
#line 35 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
WriteAttributeValue("", 1387, product.ProductName, 1387, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"center-block\">\r\n                                </a>\r\n                                <div class=\"item-content\">\r\n                                    <h4 class=\"headline-lato\">");
#nullable restore
#line 38 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
                                                         Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                    <div class=""item-footer clearfix"">
                                        <div class=""footer-content"">
                                            <div class=""wrap clearfix"">
                                                <span class=""text-primary"" style=""font-size:1.5em"">");
#nullable restore
#line 42 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
                                                                                              Write(String.Format("{0:c}", product.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"footer-button\">\r\n                                            <a class=\"btn trans-btn\"");
            BeginWriteAttribute("href", " href=\"", 2221, "\"", 2299, 1);
#nullable restore
#line 46 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
WriteAttributeValue("", 2228, Url.Action("AddToCart", "Cart", new { productId = product.ProductID }), 2228, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add to cart</a>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 52 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contoso.Apps.SportsLeague.Web.Models.StoreIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
