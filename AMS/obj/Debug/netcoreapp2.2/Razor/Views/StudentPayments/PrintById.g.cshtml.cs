#pragma checksum "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\PrintById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c494c733ed22ec82216b09dbdd42cc4f3b31be8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentPayments_PrintById), @"mvc.1.0.view", @"/Views/StudentPayments/PrintById.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StudentPayments/PrintById.cshtml", typeof(AspNetCore.Views_StudentPayments_PrintById))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c494c733ed22ec82216b09dbdd42cc4f3b31be8f", @"/Views/StudentPayments/PrintById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cea8c9a7a39c059a3c8516ab26e1dbc95d2b05e", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentPayments_PrintById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AMS.Models.StudentPayments>
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\PrintById.cshtml"
  
    ViewData["Title"] = "Details";
    //Layout = "~/Views/Shared/_LayoutAccountant.cshtml";

#line default
#line hidden
            BeginContext(139, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c494c733ed22ec82216b09dbdd42cc4f3b31be8f4239", async() => {
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
            BeginContext(187, 901, true);
            WriteLiteral(@"

<div class=""app-content"">
    <br/>
    <br/>
    <br/>
    <h1 class=""text-center"">New Prattasha High School</h1>
    <h1 class=""text-center"">Student Payment Information</h1>
    <br/>

    <table class=""table table-bordered table-hover"">
        <thead>
        <tr>
            <th>
                Student Id
            </th>

            <th>
                Fee
            </th>
            <th>
                Payment Type
            </th>

            <th>
                Fine
            </th>
            <th>
                Discount
            </th>
            <th>
                Paid Amount
            </th>
            <th>
                Payment Date
            </th>
            <th>
                Remarks
            </th>


        </tr>
        </thead>
        <tbody>


        <tr>
            <td>
                ");
            EndContext();
            BeginContext(1089, 45, false);
#line 55 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\PrintById.cshtml"
           Write(Html.DisplayFor(modelItem => Model.StudentId));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1192, 44, false);
#line 59 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\PrintById.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Fee.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1236, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1292, 52, false);
#line 62 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\PrintById.cshtml"
           Write(Html.DisplayFor(modelItem => Model.PaymentType.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1344, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1402, 40, false);
#line 66 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\PrintById.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Fine));

#line default
#line hidden
            EndContext();
            BeginContext(1442, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1498, 44, false);
#line 69 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\PrintById.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(1542, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1598, 46, false);
#line 72 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\PrintById.cshtml"
           Write(Html.DisplayFor(modelItem => Model.PaidAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1644, 58, true);
            WriteLiteral(" Tk\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1703, 47, false);
#line 75 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\PrintById.cshtml"
           Write(Html.DisplayFor(modelItem => Model.PaymentDate));

#line default
#line hidden
            EndContext();
            BeginContext(1750, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1806, 43, false);
#line 78 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\PrintById.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Remarks));

#line default
#line hidden
            EndContext();
            BeginContext(1849, 177, true);
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n        </tr>\r\n\r\n        </tbody>\r\n    </table>\r\n    <br/>\r\n    <br/>\r\n    <br/>\r\n    <br/>\r\n    <br/>\r\n    <br/>\r\n    <h4>Signature & Date</h4>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AMS.Models.StudentPayments> Html { get; private set; }
    }
}
#pragma warning restore 1591
