#pragma checksum "C:\Users\tnqar\Desktop\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Blog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7199a468704a20ea1cf22c3ca9a239c76924f94d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.views_shared_Components_Blog_Default), @"mvc.1.0.view", @"/views/shared/Components/Blog/Default.cshtml")]
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
#line 1 "C:\Users\tnqar\Desktop\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\_ViewImports.cshtml"
using asp.net_core_empty_task.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tnqar\Desktop\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\_ViewImports.cshtml"
using asp.net_core_empty_task.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7199a468704a20ea1cf22c3ca9a239c76924f94d", @"/views/shared/Components/Blog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0afbe3d14077ad01d5282a0a10a686f78a57d8ff", @"/views/_ViewImports.cshtml")]
    public class views_shared_Components_Blog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section id=\"blog\">\r\n    <div class=\"container\">\r\n        <div class=\"row py-5\">\r\n            <div class=\"offset-lg-3 col-lg-6\">\r\n                <div class=\"section-title\">\r\n                    <h1>");
#nullable restore
#line 8 "C:\Users\tnqar\Desktop\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Blog\Default.cshtml"
                   Write(Model.blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"text-black-50\">\r\n                        ");
#nullable restore
#line 10 "C:\Users\tnqar\Desktop\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Blog\Default.cshtml"
                   Write(Model.blog.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row pb-5\">\r\n");
#nullable restore
#line 16 "C:\Users\tnqar\Desktop\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Blog\Default.cshtml"
             foreach (var blogItem in @Model.blogItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-4\">\r\n                    <div class=\"item\">\r\n                        <div class=\"img position-relative\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 715, "\"", 736, 1);
#nullable restore
#line 21 "C:\Users\tnqar\Desktop\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Blog\Default.cshtml"
WriteAttributeValue("", 721, blogItem.image, 721, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 755, "\"", 761, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"date rounded bg-light position-absolute py-1 px-2\">\r\n                                <span>");
#nullable restore
#line 23 "C:\Users\tnqar\Desktop\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Blog\Default.cshtml"
                                 Write(blogItem.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"text mt-3 text-center px-5\">\r\n                            <h5>");
#nullable restore
#line 27 "C:\Users\tnqar\Desktop\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Blog\Default.cshtml"
                           Write(blogItem.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"text-black-50\">\r\n                                ");
#nullable restore
#line 29 "C:\Users\tnqar\Desktop\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Blog\Default.cshtml"
                           Write(blogItem.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 34 "C:\Users\tnqar\Desktop\Aykhanexe-Asp.net-core-mvc-florella\asp.net core empty task\views\shared\Components\Blog\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
