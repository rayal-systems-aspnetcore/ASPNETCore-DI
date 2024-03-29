#pragma checksum "C:\D-Drive\Pankaj\Learning\code\DotNet\ASP.Net Core DI\src\TennisBookings.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d66c156537301b2cc410e4e49e07e41f6fd97b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TennisBookings.Web.Areas.Admin.Views.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(TennisBookings.Web.Areas.Admin.Views.Home.Views_Home_Index))]
namespace TennisBookings.Web.Areas.Admin.Views.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d66c156537301b2cc410e4e49e07e41f6fd97b5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37e0016e8b767a9347cbf147cbfe9aa5d7846eff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TennisBookings.Web.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\D-Drive\Pankaj\Learning\code\DotNet\ASP.Net Core DI\src\TennisBookings.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Welcome to our Tennis Club";

#line default
#line hidden
            BeginContext(115, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(122, 17, false);
#line 6 "C:\D-Drive\Pankaj\Learning\code\DotNet\ASP.Net Core DI\src\TennisBookings.Web\Views\Home\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(139, 166, true);
            WriteLiteral("</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"alert alert-info\" role=\"alert\">\r\n            <h4>How\'s the weather?</h4>\r\n            <p>");
            EndContext();
            BeginContext(306, 24, false);
#line 12 "C:\D-Drive\Pankaj\Learning\code\DotNet\ASP.Net Core DI\src\TennisBookings.Web\Views\Home\Index.cshtml"
          Write(Model.WeatherDescription);

#line default
#line hidden
            EndContext();
            BeginContext(330, 1111, true);
            WriteLiteral(@"</p>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <p>
            We are a friendly and well-equipped tennis club in the sunny seaside town of Brighton. We cater to players of all standards
            with our award-winning courts and training. Whether you want a friendly game, some serious competition
            or to improve your skills, we are the club for you.
        </p>
        <p>
            We have three fantastic grass courts and for the winter season and rainy days, high quality air-conditioned indoor courts for our premium members. Our
            clubhouse is equipped with changing and shower facilities for those before work sessions!
        </p>
    </div>
</div>

<h3>Want to take a look around?</h3>

<div class=""row"">
    <div class=""col-md-12"">
        <p>
            We offer a free trial day to all prospective members where you can try out the courts and facilities. Our membership starts at only £40
            per month");
            WriteLiteral(" which includes some training time with our club pro.\r\n        </p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TennisBookings.Web.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
