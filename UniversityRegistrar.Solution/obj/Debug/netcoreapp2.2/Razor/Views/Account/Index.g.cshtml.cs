#pragma checksum "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0a989d288f5ee6d928c203eb38fa22bffd2ab2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
#line 5 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0a989d288f5ee6d928c203eb38fa22bffd2ab2f", @"/Views/Account/Index.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(58, 46, true);
            WriteLiteral("\n<h2>Authentication with Identity</h2>\n<hr />\n");
            EndContext();
#line 9 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(142, 13, true);
            WriteLiteral("    <p>Hello ");
            EndContext();
            BeginContext(156, 18, false);
#line 11 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Index.cshtml"
        Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(174, 6, true);
            WriteLiteral("!</p>\n");
            EndContext();
#line 12 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Index.cshtml"
     using (Html.BeginForm("LogOff", "Account"))
    {

#line default
#line hidden
            BeginContext(235, 72, true);
            WriteLiteral("        <input type=\"submit\" class=\"btn btn-default\" value=\"Log out\" />\n");
            EndContext();
#line 15 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Index.cshtml"
    }

#line default
#line hidden
#line 15 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Index.cshtml"
     
}
else
{

#line default
#line hidden
            BeginContext(322, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(330, 39, false);
#line 19 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Index.cshtml"
  Write(Html.ActionLink("Register", "Register"));

#line default
#line hidden
            EndContext();
            BeginContext(369, 12, true);
            WriteLiteral("</p>\n    <p>");
            EndContext();
            BeginContext(382, 34, false);
#line 20 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Index.cshtml"
  Write(Html.ActionLink("Log in", "Login"));

#line default
#line hidden
            EndContext();
            BeginContext(416, 12, true);
            WriteLiteral("</p>\n    <p>");
            EndContext();
            BeginContext(429, 40, false);
#line 21 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Index.cshtml"
  Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(469, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 22 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/UniversityRegistrar.Solution/UniversityRegistrar.Solution/Views/Account/Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
