#pragma checksum "C:\Users\Aykhan\Desktop\Yeni klasör\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Product\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67bd209fb9ba1ec554feaa8f31e2c2f96c649c20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.views_shared_Components_Product_Default), @"mvc.1.0.view", @"/views/shared/Components/Product/Default.cshtml")]
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
#line 1 "C:\Users\Aykhan\Desktop\Yeni klasör\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\_ViewImports.cshtml"
using asp.net_core_empty_task.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aykhan\Desktop\Yeni klasör\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\_ViewImports.cshtml"
using asp.net_core_empty_task.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67bd209fb9ba1ec554feaa8f31e2c2f96c649c20", @"/views/shared/Components/Product/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed7f45adea8b08e45dd6a554e56227dc3b270bf5", @"/views/_ViewImports.cshtml")]
    public class views_shared_Components_Product_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Aykhan\Desktop\Yeni klasör\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Product\Default.cshtml"
 foreach (var product in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-6 col-md-4 col-lg-3 mt-3\">\n        <div class=\"product-item text-center\" data-id=\"");
#nullable restore
#line 6 "C:\Users\Aykhan\Desktop\Yeni klasör\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Product\Default.cshtml"
                                                  Write(product.Category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n            <div class=\"img\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 244, "\"", 251, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 278, "\"", 298, 1);
#nullable restore
#line 9 "C:\Users\Aykhan\Desktop\Yeni klasör\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Product\Default.cshtml"
WriteAttributeValue("", 284, product.Photo, 284, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 317, "\"", 323, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                </a>\n            </div>\n            <div class=\"title mt-3\">\n                <h6>");
#nullable restore
#line 13 "C:\Users\Aykhan\Desktop\Yeni klasör\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Product\Default.cshtml"
               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n            </div>\n            <div class=\"price\">\n                <span class=\"text-black-50 add-to-card\" data-id=\"");
#nullable restore
#line 16 "C:\Users\Aykhan\Desktop\Yeni klasör\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Product\Default.cshtml"
                                                            Write(product.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Add to cart</span>\n                <span class=\"text-black-50\">$");
#nullable restore
#line 17 "C:\Users\Aykhan\Desktop\Yeni klasör\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Product\Default.cshtml"
                                        Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 21 "C:\Users\Aykhan\Desktop\Yeni klasör\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Product\Default.cshtml"
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
