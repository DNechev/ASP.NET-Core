#pragma checksum "C:\Users\dido9\source\repos\Eventures\Eventures\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28b6f815053a4147efb4e44be47379924091bc10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Eventures.Pages.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(Eventures.Pages.Home.Views_Home_Index))]
namespace Eventures.Pages.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\dido9\source\repos\Eventures\Eventures\Views\_ViewImports.cshtml"
using Eventures;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28b6f815053a4147efb4e44be47379924091bc10", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"542bcdd39e2d0bccb17ff1cf87ac87f894b2c6b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\dido9\source\repos\Eventures\Eventures\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#line 5 "C:\Users\dido9\source\repos\Eventures\Eventures\Views\Home\Index.cshtml"
 if (!User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(84, 398, true);
            WriteLiteral(@"    <div class=""jumbotron bg-eventures font-weight-bolder w-75 mx-auto"">
        <h1>Eventures - The best ticket service in the world.</h1>
        <hr class=""hr-2 bg-dark"" />
        <h3 class=""mt-4""><a href=""/Identity/Account/Login"">Login</a> to start ""eventing"".</h3>
        <h3 class=""mt-4""><a href=""/Identity/Account/Register"">Register</a> if you don't have an account.</h3>
    </div>
");
            EndContext();
#line 13 "C:\Users\dido9\source\repos\Eventures\Eventures\Views\Home\Index.cshtml"
}
else if (User.IsInRole("User"))
{

#line default
#line hidden
            BeginContext(521, 134, true);
            WriteLiteral("    <div class=\"jumbotron bg-eventures font-weight-bolder w-75 mx-auto\">\r\n        <h1 class=\"text-center font-weight-bolder\">Welcome, ");
            EndContext();
            BeginContext(656, 18, false);
#line 17 "C:\Users\dido9\source\repos\Eventures\Eventures\Views\Home\Index.cshtml"
                                                       Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(674, 183, true);
            WriteLiteral("!</h1>\r\n        <hr class=\"hr-2 bg-secondary\" />\r\n        <h4 class=\"mt-4 font-weight-normal text-center text-secondary\">Eventures wishes you an exiting experience.</h4>\r\n    </div>\r\n");
            EndContext();
#line 21 "C:\Users\dido9\source\repos\Eventures\Eventures\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(869, 152, true);
            WriteLiteral("    <div class=\"jumbotron bg-eventures font-weight-bolder w-75 mx-auto\">\r\n        <h1 class=\"text-center font-weight-bolder\">Greetings, Administrator - ");
            EndContext();
            BeginContext(1022, 18, false);
#line 25 "C:\Users\dido9\source\repos\Eventures\Eventures\Views\Home\Index.cshtml"
                                                                         Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1040, 156, true);
            WriteLiteral("!</h1>\r\n        <hr class=\"hr-2 bg-secondary\" />\r\n        <h4 class=\"mt-4 font-weight-normal text-center text-secondary\">Enjoy your work.</h4>\r\n    </div>\r\n");
            EndContext();
#line 29 "C:\Users\dido9\source\repos\Eventures\Eventures\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1199, 2, true);
            WriteLiteral("\r\n");
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