#pragma checksum "C:\building-a-web-app-with-asp.net-core\9 - ASP.NET Core Identity\9.8 - Use Identity in Read Operations\DutchTreat\DutchTreat\Views\App\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a91cdf7c867e36f7c397cb7c1950a9cdd9bb8a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Shop), @"mvc.1.0.view", @"/Views/App/Shop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/App/Shop.cshtml", typeof(AspNetCore.Views_App_Shop))]
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
#line 1 "C:\building-a-web-app-with-asp.net-core\9 - ASP.NET Core Identity\9.8 - Use Identity in Read Operations\DutchTreat\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.Controllers;

#line default
#line hidden
#line 2 "C:\building-a-web-app-with-asp.net-core\9 - ASP.NET Core Identity\9.8 - Use Identity in Read Operations\DutchTreat\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.ViewModels;

#line default
#line hidden
#line 3 "C:\building-a-web-app-with-asp.net-core\9 - ASP.NET Core Identity\9.8 - Use Identity in Read Operations\DutchTreat\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.Data.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a91cdf7c867e36f7c397cb7c1950a9cdd9bb8a5", @"/Views/App/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"402ff29ed5304f90d7247425045b59e26db665d3", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(29, 25, true);
            WriteLiteral("<h1>Shop</h1>\r\n<p>Count: ");
            EndContext();
            BeginContext(55, 13, false);
#line 3 "C:\building-a-web-app-with-asp.net-core\9 - ASP.NET Core Identity\9.8 - Use Identity in Read Operations\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
     Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(68, 29, true);
            WriteLiteral("</p>\r\n\r\n<div class=\"row\">\r\n\r\n");
            EndContext();
#line 7 "C:\building-a-web-app-with-asp.net-core\9 - ASP.NET Core Identity\9.8 - Use Identity in Read Operations\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
            BeginContext(135, 148, true);
            WriteLiteral("        <div class=\"col-md-3\">\r\n            <div class=\"card\" style=\"margin:10px\">\r\n                <div class=\"product-info\">\r\n                    ");
            EndContext();
            BeginContext(283, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f295ea11361b4a6395a71da33ce9d6e3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 293, "~/img/", 293, 6, true);
#line 12 "C:\building-a-web-app-with-asp.net-core\9 - ASP.NET Core Identity\9.8 - Use Identity in Read Operations\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
AddHtmlAttributeValue("", 299, p.ArtId, 299, 10, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 309, ".jpg", 309, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "C:\building-a-web-app-with-asp.net-core\9 - ASP.NET Core Identity\9.8 - Use Identity in Read Operations\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
AddHtmlAttributeValue("", 338, p.Title, 338, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(350, 26, true);
            WriteLiteral("\r\n                    <h3>");
            EndContext();
            BeginContext(377, 10, false);
#line 13 "C:\building-a-web-app-with-asp.net-core\9 - ASP.NET Core Identity\9.8 - Use Identity in Read Operations\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                   Write(p.Category);

#line default
#line hidden
            EndContext();
            BeginContext(387, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(391, 6, false);
#line 13 "C:\building-a-web-app-with-asp.net-core\9 - ASP.NET Core Identity\9.8 - Use Identity in Read Operations\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                                 Write(p.Size);

#line default
#line hidden
            EndContext();
            BeginContext(397, 90, true);
            WriteLiteral("</h3>\r\n                    <ul class=\"product-props\">\r\n                        <li>Price: ");
            EndContext();
            BeginContext(488, 7, false);
#line 15 "C:\building-a-web-app-with-asp.net-core\9 - ASP.NET Core Identity\9.8 - Use Identity in Read Operations\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                              Write(p.Price);

#line default
#line hidden
            EndContext();
            BeginContext(495, 43, true);
            WriteLiteral("</li>\r\n                        <li>Artist: ");
            EndContext();
            BeginContext(539, 8, false);
#line 16 "C:\building-a-web-app-with-asp.net-core\9 - ASP.NET Core Identity\9.8 - Use Identity in Read Operations\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                               Write(p.Artist);

#line default
#line hidden
            EndContext();
            BeginContext(547, 42, true);
            WriteLiteral("</li>\r\n                        <li>Title: ");
            EndContext();
            BeginContext(590, 7, false);
#line 17 "C:\building-a-web-app-with-asp.net-core\9 - ASP.NET Core Identity\9.8 - Use Identity in Read Operations\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                              Write(p.Title);

#line default
#line hidden
            EndContext();
            BeginContext(597, 48, true);
            WriteLiteral("</li>\r\n                        <li>Description: ");
            EndContext();
            BeginContext(646, 16, false);
#line 18 "C:\building-a-web-app-with-asp.net-core\9 - ASP.NET Core Identity\9.8 - Use Identity in Read Operations\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                                    Write(p.ArtDescription);

#line default
#line hidden
            EndContext();
            BeginContext(662, 151, true);
            WriteLiteral("</li>\r\n                    </ul>\r\n                    <button id=\"buyButton\">Buy</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 24 "C:\building-a-web-app-with-asp.net-core\9 - ASP.NET Core Identity\9.8 - Use Identity in Read Operations\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
    }

#line default
#line hidden
            BeginContext(820, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
