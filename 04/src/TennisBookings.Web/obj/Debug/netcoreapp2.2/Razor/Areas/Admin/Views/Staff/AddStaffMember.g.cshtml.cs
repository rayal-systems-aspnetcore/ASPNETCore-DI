#pragma checksum "C:\D-Drive\Pankaj\Learning\code\DotNet\ASP.Net Core DI\04\src\TennisBookings.Web\Areas\Admin\Views\Staff\AddStaffMember.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06997f74ad7b4550e0996cc066eba6f0063979ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TennisBookings.Web.Areas.Admin.Views.Staff.Areas_Admin_Views_Staff_AddStaffMember), @"mvc.1.0.view", @"/Areas/Admin/Views/Staff/AddStaffMember.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Staff/AddStaffMember.cshtml", typeof(TennisBookings.Web.Areas.Admin.Views.Staff.Areas_Admin_Views_Staff_AddStaffMember))]
namespace TennisBookings.Web.Areas.Admin.Views.Staff
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\D-Drive\Pankaj\Learning\code\DotNet\ASP.Net Core DI\04\src\TennisBookings.Web\Areas\Admin\Views\Staff\AddStaffMember.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06997f74ad7b4550e0996cc066eba6f0063979ac", @"/Areas/Admin/Views/Staff/AddStaffMember.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37e0016e8b767a9347cbf147cbfe9aa5d7846eff", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Staff_AddStaffMember : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Areas.Admin.ViewModels.AddStaffMemberViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\D-Drive\Pankaj\Learning\code\DotNet\ASP.Net Core DI\04\src\TennisBookings.Web\Areas\Admin\Views\Staff\AddStaffMember.cshtml"
  
    ViewData["Title"] = "Add Staff Member";

#line default
#line hidden
            BeginContext(207, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(214, 17, false);
#line 8 "C:\D-Drive\Pankaj\Learning\code\DotNet\ASP.Net Core DI\04\src\TennisBookings.Web\Areas\Admin\Views\Staff\AddStaffMember.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(231, 65, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            EndContext();
            BeginContext(296, 793, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06997f74ad7b4550e0996cc066eba6f0063979ac4536", async() => {
                BeginContext(319, 56, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(376, 31, false);
#line 14 "C:\D-Drive\Pankaj\Learning\code\DotNet\ASP.Net Core DI\04\src\TennisBookings.Web\Areas\Admin\Views\Staff\AddStaffMember.cshtml"
           Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(407, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(426, 66, false);
#line 15 "C:\D-Drive\Pankaj\Learning\code\DotNet\ASP.Net Core DI\04\src\TennisBookings.Web\Areas\Admin\Views\Staff\AddStaffMember.cshtml"
           Write(Html.TextBoxFor(m => m.FirstName, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(492, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(569, 30, false);
#line 18 "C:\D-Drive\Pankaj\Learning\code\DotNet\ASP.Net Core DI\04\src\TennisBookings.Web\Areas\Admin\Views\Staff\AddStaffMember.cshtml"
           Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(599, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(618, 65, false);
#line 19 "C:\D-Drive\Pankaj\Learning\code\DotNet\ASP.Net Core DI\04\src\TennisBookings.Web\Areas\Admin\Views\Staff\AddStaffMember.cshtml"
           Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(683, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(760, 26, false);
#line 22 "C:\D-Drive\Pankaj\Learning\code\DotNet\ASP.Net Core DI\04\src\TennisBookings.Web\Areas\Admin\Views\Staff\AddStaffMember.cshtml"
           Write(Html.LabelFor(m => m.Role));

#line default
#line hidden
                EndContext();
                BeginContext(786, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(805, 162, false);
#line 23 "C:\D-Drive\Pankaj\Learning\code\DotNet\ASP.Net Core DI\04\src\TennisBookings.Web\Areas\Admin\Views\Staff\AddStaffMember.cshtml"
           Write(Html.DropDownListFor(m => m.Role, StaffOptions.Roles.Select(r =>
                    new SelectListItem { Text = r, Value = r}), new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(967, 115, true);
                WriteLiteral("\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Add Staff Member</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1089, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Services.IStaffRolesOptionsService StaffOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas.Admin.ViewModels.AddStaffMemberViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591