#pragma checksum "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13edf89446b419b4ecd90515034a50ca0852d786"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentPayments_Delete), @"mvc.1.0.view", @"/Views/StudentPayments/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StudentPayments/Delete.cshtml", typeof(AspNetCore.Views_StudentPayments_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13edf89446b419b4ecd90515034a50ca0852d786", @"/Views/StudentPayments/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cea8c9a7a39c059a3c8516ab26e1dbc95d2b05e", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentPayments_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AMS.Models.StudentPayments>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_LayoutAccountant.cshtml";

#line default
#line hidden
            BeginContext(136, 274, true);
            WriteLiteral(@"
<div class=""app-content"">

    <h3>Are you sure you want to delete this?</h3>
    <div>

        <hr />
        <dl class=""row"">
            <dt class=""col-sm-2"">
                Payment Date
            </dt>
            <dd class=""col-sm-10"">
                ");
            EndContext();
            BeginContext(411, 43, false);
#line 19 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Delete.cshtml"
           Write(Html.DisplayFor(model => model.PaymentDate));

#line default
#line hidden
            EndContext();
            BeginContext(454, 155, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Student Id\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(610, 41, false);
#line 25 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Delete.cshtml"
           Write(Html.DisplayFor(model => model.StudentId));

#line default
#line hidden
            EndContext();
            BeginContext(651, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(724, 40, false);
#line 28 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Fine));

#line default
#line hidden
            EndContext();
            BeginContext(764, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(838, 36, false);
#line 31 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Fine));

#line default
#line hidden
            EndContext();
            BeginContext(874, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(947, 44, false);
#line 34 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(991, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1065, 40, false);
#line 37 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 156, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Paid Amount\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1262, 42, false);
#line 43 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Delete.cshtml"
           Write(Html.DisplayFor(model => model.PaidAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1377, 43, false);
#line 46 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Remarks));

#line default
#line hidden
            EndContext();
            BeginContext(1420, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1494, 39, false);
#line 49 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Remarks));

#line default
#line hidden
            EndContext();
            BeginContext(1533, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1606, 39, false);
#line 52 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Fee));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1719, 40, false);
#line 55 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Fee.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1759, 157, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Payment Type\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1917, 48, false);
#line 61 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Delete.cshtml"
           Write(Html.DisplayFor(model => model.PaymentType.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1965, 46, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        ");
            EndContext();
            BeginContext(2011, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13edf89446b419b4ecd90515034a50ca0852d78610792", async() => {
                BeginContext(2037, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2051, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13edf89446b419b4ecd90515034a50ca0852d78611189", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 66 "C:\Users\Shishir\Desktop\final project\AMS WebApp\AMS\Views\StudentPayments\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2087, 91, true);
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n            ");
                EndContext();
                BeginContext(2178, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13edf89446b419b4ecd90515034a50ca0852d78613113", async() => {
                    BeginContext(2200, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2216, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2233, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
