#pragma checksum "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d0fa845a6c55e937fd383525a0afebb3253ccd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentPayments_Index), @"mvc.1.0.view", @"/Views/StudentPayments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StudentPayments/Index.cshtml", typeof(AspNetCore.Views_StudentPayments_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d0fa845a6c55e937fd383525a0afebb3253ccd3", @"/Views/StudentPayments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cea8c9a7a39c059a3c8516ab26e1dbc95d2b05e", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentPayments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AMS.Models.StudentPayments>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/table.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PrintById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAccountant.cshtml";

#line default
#line hidden
            BeginContext(148, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0d0fa845a6c55e937fd383525a0afebb3253ccd36562", async() => {
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
            BeginContext(196, 109, true);
            WriteLiteral("\r\n\r\n<div class=\"app-content\">\r\n    <h1 class=\"text-center\">Student Payment Information</h1>\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(305, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d0fa845a6c55e937fd383525a0afebb3253ccd37935", async() => {
                BeginContext(352, 21, true);
                WriteLiteral("+ Add Student Payment");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(377, 209, true);
            WriteLiteral("\r\n    <br /> <br />\r\n\r\n    <table class=\"table table-bordered table-hover\">\r\n        <thead>\r\n        <tr>\r\n            <th>\r\n                Student Id\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(587, 39, false);
#line 23 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fee));

#line default
#line hidden
            EndContext();
            BeginContext(626, 124, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Payment Type\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(751, 40, false);
#line 30 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fine));

#line default
#line hidden
            EndContext();
            BeginContext(791, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(847, 44, false);
#line 33 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(891, 188, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Paid Amount\r\n            </th>\r\n            <th>\r\n                Payment Date\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1080, 43, false);
#line 42 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Remarks));

#line default
#line hidden
            EndContext();
            BeginContext(1123, 102, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>Action</th>\r\n        </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 49 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1274, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1335, 44, false);
#line 53 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StudentId));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1449, 43, false);
#line 57 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fee.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1492, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1560, 51, false);
#line 60 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PaymentType.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1611, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1681, 39, false);
#line 64 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fine));

#line default
#line hidden
            EndContext();
            BeginContext(1720, 68, true);
            WriteLiteral(" \r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1789, 43, false);
#line 67 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(1832, 68, true);
            WriteLiteral(" \r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1901, 45, false);
#line 70 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PaidAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1946, 70, true);
            WriteLiteral(" Tk\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2017, 46, false);
#line 73 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PaymentDate));

#line default
#line hidden
            EndContext();
            BeginContext(2063, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2131, 42, false);
#line 76 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Remarks));

#line default
#line hidden
            EndContext();
            BeginContext(2173, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2242, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d0fa845a6c55e937fd383525a0afebb3253ccd315551", async() => {
                BeginContext(2287, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2295, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2319, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d0fa845a6c55e937fd383525a0afebb3253ccd317914", async() => {
                BeginContext(2367, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2378, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2402, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d0fa845a6c55e937fd383525a0afebb3253ccd320283", async() => {
                BeginContext(2449, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2459, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2483, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d0fa845a6c55e937fd383525a0afebb3253ccd322650", async() => {
                BeginContext(2554, 5, true);
                WriteLiteral("Print");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2563, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 86 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2618, 75, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <h3>Total Amount from Student Payment: ");
            EndContext();
            BeginContext(2694, 23, false);
#line 89 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Index.cshtml"
                                      Write(ViewBag.stuPaymentTotal);

#line default
#line hidden
            EndContext();
            BeginContext(2717, 16, true);
            WriteLiteral(" Tk</h3>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AMS.Models.StudentPayments>> Html { get; private set; }
    }
}
#pragma warning restore 1591
