#pragma checksum "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41eb87e7d6dd8fd6cb950bf4deb2c5c1c17f402a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/_ViewImports.cshtml"
using CoffeeShop;

#line default
#line hidden
#line 2 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/_ViewImports.cshtml"
using CoffeeShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41eb87e7d6dd8fd6cb950bf4deb2c5c1c17f402a", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoffeeShop.Models.LoginInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/Privacy.cshtml"
  
    ViewData["Title"] = "Privacy";

#line default
#line hidden
            BeginContext(43, 67, true);
            WriteLiteral("\r\n    ViewData[\"Title\"] = \"UserData\";\r\n}\r\n\r\n<h1>List Items</h1>\r\n\r\n");
            EndContext();
            BeginContext(159, 124, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Username</th>\r\n        <th>Email</th>\r\n        <th>Passwrod</th>\r\n    </tr>\r\n");
            EndContext();
#line 18 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/Privacy.cshtml"
     foreach (var user in Model)
    {

#line default
#line hidden
            BeginContext(324, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(355, 13, false);
#line 21 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/Privacy.cshtml"
           Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(368, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(392, 10, false);
#line 22 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/Privacy.cshtml"
           Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(402, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(426, 13, false);
#line 23 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/Privacy.cshtml"
           Write(user.Password);

#line default
#line hidden
            EndContext();
            BeginContext(439, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 25 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/Privacy.cshtml"
    }

#line default
#line hidden
            BeginContext(468, 10, true);
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoffeeShop.Models.LoginInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
