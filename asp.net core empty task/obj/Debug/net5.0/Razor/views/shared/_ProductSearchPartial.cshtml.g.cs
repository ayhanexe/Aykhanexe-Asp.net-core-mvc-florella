#pragma checksum "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\shared\_ProductSearchPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8f0d43ebc35ddc5a4b44f1bd0360e2ea02e08b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.views_shared__ProductSearchPartial), @"mvc.1.0.view", @"/views/shared/_ProductSearchPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8f0d43ebc35ddc5a4b44f1bd0360e2ea02e08b7", @"/views/shared/_ProductSearchPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed7f45adea8b08e45dd6a554e56227dc3b270bf5", @"/views/_ViewImports.cshtml")]
    public class views_shared__ProductSearchPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\shared\_ProductSearchPartial.cshtml"
  
    if (@Model.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>Netice Tapilmadi</li>\r\n");
#nullable restore
#line 7 "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\shared\_ProductSearchPartial.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\shared\_ProductSearchPartial.cshtml"
         foreach (var product in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"d-flex p-0 m-0\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 236, "\"", 256, 1);
#nullable restore
#line 13 "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\shared\_ProductSearchPartial.cshtml"
WriteAttributeValue("", 242, product.Photo, 242, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px;\">\r\n                <span>");
#nullable restore
#line 14 "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\shared\_ProductSearchPartial.cshtml"
                 Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n");
#nullable restore
#line 16 "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\shared\_ProductSearchPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Aykhan\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\shared\_ProductSearchPartial.cshtml"
         
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