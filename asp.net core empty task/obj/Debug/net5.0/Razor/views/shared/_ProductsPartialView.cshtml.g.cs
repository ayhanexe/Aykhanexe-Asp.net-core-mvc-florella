#pragma checksum "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\shared\_ProductsPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8096af814f0f7b9902ce70ce1648056d4ba40ce7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.views_shared__ProductsPartialView), @"mvc.1.0.view", @"/views/shared/_ProductsPartialView.cshtml")]
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
#line 1 "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\_ViewImports.cshtml"
using asp.net_core_empty_task.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\_ViewImports.cshtml"
using asp.net_core_empty_task.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8096af814f0f7b9902ce70ce1648056d4ba40ce7", @"/views/shared/_ProductsPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0afbe3d14077ad01d5282a0a10a686f78a57d8ff", @"/views/_ViewImports.cshtml")]
    public class views_shared__ProductsPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\shared\_ProductsPartialView.cshtml"
 foreach (var product in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-6 col-md-4 col-lg-3 mt-3\">\r\n        <div class=\"product-item text-center\" data-id=\"");
#nullable restore
#line 6 "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\shared\_ProductsPartialView.cshtml"
                                                  Write(product.Category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n            <div class=\"img\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 251, "\"", 258, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 286, "\"", 306, 1);
#nullable restore
#line 9 "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\shared\_ProductsPartialView.cshtml"
WriteAttributeValue("", 292, product.Photo, 292, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 325, "\"", 331, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"title mt-3\">\r\n                <h6>");
#nullable restore
#line 13 "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\shared\_ProductsPartialView.cshtml"
               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </div>\r\n            <div class=\"price\">\r\n                <span class=\"text-black-50\">Add to cart</span>\r\n                <span class=\"text-black-50\">$");
#nullable restore
#line 17 "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\shared\_ProductsPartialView.cshtml"
                                        Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\shared\_ProductsPartialView.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591