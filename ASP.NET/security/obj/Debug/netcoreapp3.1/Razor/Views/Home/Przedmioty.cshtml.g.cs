#pragma checksum "C:\Users\Robert\source\repos\ZakupyOnline\Views\Home\Przedmioty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "445b9efe29b9362485ed766658f492157884c7c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Przedmioty), @"mvc.1.0.view", @"/Views/Home/Przedmioty.cshtml")]
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
#line 1 "C:\Users\Robert\source\repos\ZakupyOnline\Views\_ViewImports.cshtml"
using ZakupyOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Robert\source\repos\ZakupyOnline\Views\_ViewImports.cshtml"
using ZakupyOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"445b9efe29b9362485ed766658f492157884c7c9", @"/Views/Home/Przedmioty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84db9ef1a361da1acb3a17ace83c830b4a9a0c9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Przedmioty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZakupyOnline.Models.Zakupy>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Robert\source\repos\ZakupyOnline\Views\Home\Przedmioty.cshtml"
  
    ViewData["Title"] = "Przedmioty";


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "445b9efe29b9362485ed766658f492157884c7c93242", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css\">\r\n    <script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Przedmioty</h1>\r\n    <table class=\"table table-striped\">\r\n        <tr>\r\n            <th>Nazwa</th>\r\n            <th>Cena</th>\r\n            <th>Usuń</th>\r\n        </tr>\r\n        <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\Robert\source\repos\ZakupyOnline\Views\Home\Przedmioty.cshtml"
             foreach(var przedmioty in ViewBag.przedmioty)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 24 "C:\Users\Robert\source\repos\ZakupyOnline\Views\Home\Przedmioty.cshtml"
               Write(przedmioty.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 27 "C:\Users\Robert\source\repos\ZakupyOnline\Views\Home\Przedmioty.cshtml"
               Write(przedmioty.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 827, "\"", 871, 2);
            WriteAttributeValue("", 834, "/Home/PrzedmiotyDelete/", 834, 23, true);
#nullable restore
#line 29 "C:\Users\Robert\source\repos\ZakupyOnline\Views\Home\Przedmioty.cshtml"
WriteAttributeValue("", 857, przedmioty.ID, 857, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-lg active\" role=\"button\" aria-pressed=\"true\">Usuń</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Robert\source\repos\ZakupyOnline\Views\Home\Przedmioty.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <a href=\"/Home/PrzedmiotyAdd\" class=\"btn btn-primary btn-lg active\" role=\"button\" aria-pressed=\"true\">Stwórz nowe przedmioty</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZakupyOnline.Models.Zakupy> Html { get; private set; }
    }
}
#pragma warning restore 1591
