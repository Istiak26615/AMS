#pragma checksum "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\Users\AccountantIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c1e436e455ff47843e2c5874533700b6959579d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_AccountantIndex), @"mvc.1.0.view", @"/Views/Users/AccountantIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/AccountantIndex.cshtml", typeof(AspNetCore.Views_Users_AccountantIndex))]
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
#line 1 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\_ViewImports.cshtml"
using AMS;

#line default
#line hidden
#line 2 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\_ViewImports.cshtml"
using AMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1e436e455ff47843e2c5874533700b6959579d", @"/Views/Users/AccountantIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cea8c9a7a39c059a3c8516ab26e1dbc95d2b05e", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_AccountantIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/table.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\Users\AccountantIndex.cshtml"
  
    ViewData["Title"] = "Accountant";
    Layout = "~/Views/Shared/_LayoutAccountant.cshtml";

#line default
#line hidden
            BeginContext(99, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c1e436e455ff47843e2c5874533700b6959579d4083", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(147, 321, true);
            WriteLiteral(@"

<div class=""app-content"">
    <h1 class=""text-center"">Welcome To Accountant Pannel</h1>
    <br/><br/>
    
    <table class=""table table-bordered table-hover"">
        <thead>
            <tr>
                <td>
                    <b>Total Student</b>
                </td>
                <td>
                    ");
            EndContext();
            BeginContext(469, 20, false);
#line 18 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\Users\AccountantIndex.cshtml"
               Write(ViewBag.totalStudent);

#line default
#line hidden
            EndContext();
            BeginContext(489, 188, true);
            WriteLiteral(" Person\n                </td>\n            </tr>\n            <tr>\n                <td>\n                    <b>Total Staff</b>\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(678, 18, false);
#line 26 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\Users\AccountantIndex.cshtml"
               Write(ViewBag.totalStaff);

#line default
#line hidden
            EndContext();
            BeginContext(696, 210, true);
            WriteLiteral(" Person\n                </td>\n            </tr>\n\n            <tr>\n                <td>\n                    <b>Total Student Payment Collection</b>\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(907, 23, false);
#line 35 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\Users\AccountantIndex.cshtml"
               Write(ViewBag.stuPaymentTotal);

#line default
#line hidden
            EndContext();
            BeginContext(930, 199, true);
            WriteLiteral(" TK\n                </td>\n            </tr>\n\n            <tr>\n                <td>\n                    <b>Total Donation Collection</b>\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1130, 21, false);
#line 44 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\Users\AccountantIndex.cshtml"
               Write(ViewBag.donationTotal);

#line default
#line hidden
            EndContext();
            BeginContext(1151, 168, true);
            WriteLiteral(" TK\n                </td>\n            </tr>\n\n        <tr>\n            <td>\n                <b>Total Staff Salary</b>\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1320, 19, false);
#line 53 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\Users\AccountantIndex.cshtml"
           Write(ViewBag.salaryTotal);

#line default
#line hidden
            EndContext();
            BeginContext(1339, 163, true);
            WriteLiteral(" TK\n            </td>\n        </tr>\n        \n        <tr>\n            <td>\n                <b>Total Expense</b>\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1503, 20, false);
#line 62 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\Users\AccountantIndex.cshtml"
           Write(ViewBag.expenseTotal);

#line default
#line hidden
            EndContext();
            BeginContext(1523, 99, true);
            WriteLiteral(" TK\n            </td>\n        </tr>\n        </thead>\n    </table>\n    <br/>\n             \n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
