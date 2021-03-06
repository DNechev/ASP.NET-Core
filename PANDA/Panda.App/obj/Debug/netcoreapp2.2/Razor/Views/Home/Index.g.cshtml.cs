#pragma checksum "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a80ac1e402f926642acdfd9b4a06e3095bf581ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Panda.App.Views.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(Panda.App.Views.Home.Views_Home_Index))]
namespace Panda.App.Views.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\_ViewImports.cshtml"
using Panda.App;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a80ac1e402f926642acdfd9b4a06e3095bf581ed", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"003302008ecbbd1a2318ec4c95ec61eae7b76fae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Panda.App.Models.Package.PackageHomeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

    List<Panda.App.Models.Package.PackageHomeViewModel> pendingPackages = null;
    List<Panda.App.Models.Package.PackageHomeViewModel> shippedPackages = null;
    List<Panda.App.Models.Package.PackageHomeViewModel> deliveredPackages = null;

    if (this.User.Identity.IsAuthenticated)
    {
        pendingPackages = Model.Where(package => package.Status == "Pending").ToList();
        shippedPackages = Model.Where(package => package.Status == "Shipped").ToList();
        deliveredPackages = Model.Where(package => package.Status == "Delivered").ToList();
    }

#line default
#line hidden
            BeginContext(666, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 18 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
 if (!this.User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(711, 332, true);
            WriteLiteral(@"    <div class=""jumbotron mt-3 bg-panda"">
        <h1 class=""text-white"">Welcome to PANDA Delivery Services.</h1>
        <hr class=""bg-white hr-2"" />
        <h3 class=""text-white""><a href=""/login"">Login</a> if you have an account.</h3>
        <h3 class=""text-white""><a href=""/register"">Register</a> if you don't.</h3>
    </div>
");
            EndContext();
#line 26 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
}
else
{
    if (this.User.IsInRole("Admin"))
    {

#line default
#line hidden
            BeginContext(1095, 53, true);
            WriteLiteral("        <h1 class=\"text-center\">Hello, Administrator ");
            EndContext();
            BeginContext(1149, 23, false);
#line 31 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
                                                Write(this.User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1172, 7, true);
            WriteLiteral("!</h1>\n");
            EndContext();
#line 32 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1200, 31, true);
            WriteLiteral("<h1 class=\"text-center\">Hello, ");
            EndContext();
            BeginContext(1232, 23, false);
#line 35 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
                          Write(this.User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1255, 7, true);
            WriteLiteral("!</h1>\n");
            EndContext();
#line 36 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1268, 208, true);
            WriteLiteral("    <hr class=\"hr-2 bg-panda\">\n    <div class=\"d-flex justify-content-between\">\n        <div class=\"w-25 bg-white\">\n            <h2 class=\"text-center\">Pending</h2>\n            <div class=\"border-panda p-3\">\n");
            EndContext();
#line 42 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
                 foreach (var package in pendingPackages)
                {

#line default
#line hidden
            BeginContext(1552, 109, true);
            WriteLiteral("                    <div class=\"p-2 d-flex justify-content-around\">\n                        <h4 class=\"w-75\">");
            EndContext();
            BeginContext(1662, 19, false);
#line 45 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
                                    Write(package.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1681, 32, true);
            WriteLiteral("</h4>\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1713, "\"", 1749, 2);
            WriteAttributeValue("", 1720, "/Packages/Details/", 1720, 18, true);
#line 46 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
WriteAttributeValue("", 1738, package.Id, 1738, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1750, 77, true);
            WriteLiteral(" class=\"btn bg-panda text-white w-25\">Details</a>\n                    </div>\n");
            EndContext();
#line 48 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1845, 162, true);
            WriteLiteral("            </div>\n        </div>\n        <div class=\"w-25 bg-white\">\n            <h2 class=\"text-center\">Shipped</h2>\n            <div class=\"border-panda p-3\">\n");
            EndContext();
#line 54 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
                 foreach (var package in shippedPackages)
                {

#line default
#line hidden
            BeginContext(2083, 109, true);
            WriteLiteral("                    <div class=\"p-2 d-flex justify-content-around\">\n                        <h4 class=\"w-75\">");
            EndContext();
            BeginContext(2193, 19, false);
#line 57 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
                                    Write(package.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2212, 32, true);
            WriteLiteral("</h4>\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2244, "\"", 2280, 2);
            WriteAttributeValue("", 2251, "/Packages/Details/", 2251, 18, true);
#line 58 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
WriteAttributeValue("", 2269, package.Id, 2269, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2281, 77, true);
            WriteLiteral(" class=\"btn bg-panda text-white w-25\">Details</a>\n                    </div>\n");
            EndContext();
#line 60 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2376, 164, true);
            WriteLiteral("            </div>\n        </div>\n        <div class=\"w-25 bg-white\">\n            <h2 class=\"text-center\">Delivered</h2>\n            <div class=\"border-panda p-3\">\n");
            EndContext();
#line 66 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
                 foreach (var package in deliveredPackages)
                {

#line default
#line hidden
            BeginContext(2618, 109, true);
            WriteLiteral("                    <div class=\"p-2 d-flex justify-content-around\">\n                        <h4 class=\"w-75\">");
            EndContext();
            BeginContext(2728, 19, false);
#line 69 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
                                    Write(package.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2747, 32, true);
            WriteLiteral("</h4>\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2779, "\"", 2815, 2);
            WriteAttributeValue("", 2786, "/Packages/Acquire/", 2786, 18, true);
#line 70 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
WriteAttributeValue("", 2804, package.Id, 2804, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2816, 77, true);
            WriteLiteral(" class=\"btn bg-panda text-white w-25\">Acquire</a>\n                    </div>\n");
            EndContext();
#line 72 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2911, 45, true);
            WriteLiteral("            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 76 "C:\Users\dido9\Desktop\DNGit\ASP.NET Core\PANDA\Panda.App\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Panda.App.Models.Package.PackageHomeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
