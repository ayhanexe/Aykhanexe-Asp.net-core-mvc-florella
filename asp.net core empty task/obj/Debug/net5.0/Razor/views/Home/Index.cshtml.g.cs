#pragma checksum "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb0f07b69e862a62a21abe2e1e980855f975d434"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.views_Home_Index), @"mvc.1.0.view", @"/views/Home/Index.cshtml")]
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
#line 1 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\_ViewImports.cshtml"
using asp.net_core_empty_task.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\_ViewImports.cshtml"
using asp.net_core_empty_task.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb0f07b69e862a62a21abe2e1e980855f975d434", @"/views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed7f45adea8b08e45dd6a554e56227dc3b270bf5", @"/views/_ViewImports.cshtml")]
    public class views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexModelView>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!-- MAIN START -->\n\n<main>\n\n    <!-- SLIDER START -->\n\n    <section id=\"slider\">\n        <div class=\"owl-carousel slider\">\n");
#nullable restore
#line 11 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
             foreach (var sliderItem in Model.sliderItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb0f07b69e862a62a21abe2e1e980855f975d4343735", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 276, "~/img/", 276, 6, true);
#nullable restore
#line 14 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
AddHtmlAttributeValue("", 282, sliderItem.image, 282, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n");
#nullable restore
#line 16 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n        <div class=\"container context pl-lg-5 ml-lg-3\">\n            <div class=\"row\">\n                <div class=\"col-lg-5\">\n                    <div class=\"text\">\n                        ");
#nullable restore
#line 22 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                   Write(Html.Raw(Model.slider.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 23 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                   Write(Html.Raw(Model.slider.desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                    <div class=\"img\">\n                        ");
#nullable restore
#line 26 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                   Write(Html.Raw(Model.slider.logo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SLIDER END -->
    <!-- PRODUCTS START -->

    <section id=""products"">
        <div class=""container"">
            <div class=""row pt-5"">
                <div class=""col-12 d-flex justify-content-between"">
                    <ul class=""category-mobile d-md-none list-unstyled"">
                        <li>
                            <a");
            BeginWriteAttribute("href", " href=\"", 1192, "\"", 1199, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\n                            <i class=\"fas fa-caret-down\"></i>\n                            <ul class=\"category list-unstyled\" style=\"display: none;\">\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1427, "\"", 1434, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\n");
#nullable restore
#line 46 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                                 foreach (var category in Model.categories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1615, "\"", 1622, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 48 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                                                       Write(category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 48 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                                                                                 Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 49 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\n                        </li>\n                    </ul>\n                    <ul class=\"category d-none d-md-flex list-unstyled\">\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1910, "\"", 1917, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\n");
#nullable restore
#line 55 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                         foreach (var category in Model.categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2074, "\"", 2081, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 57 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                                               Write(category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 57 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                                                                         Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 58 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\n                    <ul class=\"list-unstyled\">\n                        <li>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2300, "\"", 2307, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""mr-2"">Filter</a>
                            <i class=""fas fa-caret-down""></i>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""row"" id=""product-items-container"">
                ");
#nullable restore
#line 69 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <button id=\"loadMore\" class=\"btn btn-lg btn-primary d-block mx-auto mt-5\" data-skip=\"");
#nullable restore
#line 71 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                                                                                            Write(ViewBag.SkipCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">Load More</button>
        </div>
    </section>

    <!-- PRODUCTS END -->
    <!-- ABOUT START -->

    <section id=""about"">
        <div class=""container py-5"">
            <div class=""row py-5"">
                <div class=""col-lg-6"">
                    <div class=""img"">
                        ");
#nullable restore
#line 83 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                   Write(Html.Raw(Model.videoSection.photo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                            <i class=""fas fa-play fa-lg""></i>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                        ");
#nullable restore
#line 91 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                   Write(Html.Raw(Model.videoSection.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 92 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                   Write(Html.Raw(Model.videoSection.desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                        <ul class=\"list-unstyled\">\n");
#nullable restore
#line 95 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                             foreach (var item in Model.videoSectionItems)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                           Write(Html.Raw(item.text));

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                                                    
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- ABOUT END -->
    <!-- EXPERTS START -->

    <section id=""experts"">
        <div class=""container"">
            <div class=""row py-5"">
                <div class=""offset-lg-3 col-lg-6"">
                    <div class=""section-title"">
                        <h1>");
#nullable restore
#line 114 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                       Write(Model.experts.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                        <p class=\"text-black-50\">\n                            ");
#nullable restore
#line 116 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                       Write(Model.experts.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </p>\n                    </div>\n                </div>\n            </div>\n            <div class=\"row pb-5\">\n");
#nullable restore
#line 122 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                 foreach (var expert in Model.expertItems)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-3\">\n                        <div class=\"item text-center\">\n                            <div class=\"img\">\n                                <img");
            BeginWriteAttribute("src", " src=\"", 4739, "\"", 4758, 1);
#nullable restore
#line 127 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
WriteAttributeValue("", 4745, expert.Photo, 4745, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("alt", " alt=\"", 4792, "\"", 4798, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            </div>\n                            <div class=\"text mt-3\">\n                                <h6>");
#nullable restore
#line 130 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                               Write(expert.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                                <p class=\"text-black-50\">");
#nullable restore
#line 131 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                                                    Write(expert.Expert);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                        </div>\n                    </div>\n");
#nullable restore
#line 135 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </section>\n\n    <!-- EXPERTS END -->\n    <!-- SUBSCRIBE START -->\n\n    <section id=\"subscribe\"");
            BeginWriteAttribute("style", " style=\"", 5261, "\"", 5351, 6);
            WriteAttributeValue("", 5269, "background:url(", 5269, 15, true);
#nullable restore
#line 143 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
WriteAttributeValue("", 5284, Model.subscription.Photo, 5284, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5309, ")", 5309, 1, true);
            WriteAttributeValue(" ", 5310, "no-repeat", 5311, 10, true);
            WriteAttributeValue(" ", 5320, "center;", 5321, 8, true);
            WriteAttributeValue(" ", 5328, "background-size:cover;", 5329, 23, true);
            EndWriteAttribute();
            WriteLiteral(">\n        <div class=\"container py-5\">\n            <div class=\"row py-5\">\n                <div class=\"col-12\">\n                    <div class=\"content text-center py-5\">\n                        <h3>");
#nullable restore
#line 148 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
                       Write(Model.subscription.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                            <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                            <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SUBSCRIBE END -->
    <!-- BLOG START -->

    ");
#nullable restore
#line 162 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Blog"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <!-- BLOG END -->\n    <!-- SAY START -->\n\n    ");
#nullable restore
#line 167 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Say"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <!-- SAY END -->\n    <!-- INSTAGRAM START -->\n\n    ");
#nullable restore
#line 172 "C:\Users\aykhansab\Desktop\Aykhanexe-Asp.net-core-mvc-florella-master\asp.net core empty task\views\Home\Index.cshtml"
Write(await Component.InvokeAsync("FiorelloSlider"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <!-- INSTAGRAM END -->\n\n</main>\n\n<!-- MAIN END -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591
