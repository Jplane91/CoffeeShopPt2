#pragma checksum "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/ViewUserData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "228f9fb69b12206a8a23674157e9e07a7fce30ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewUserData), @"mvc.1.0.view", @"/Views/Home/ViewUserData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewUserData.cshtml", typeof(AspNetCore.Views_Home_ViewUserData))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"228f9fb69b12206a8a23674157e9e07a7fce30ca", @"/Views/Home/ViewUserData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewUserData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoffeeShop.Models.LoginInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/ViewUserData.cshtml"
  
    ViewData["Title"] = "UserData";

#line default
#line hidden
            BeginContext(46, 25, true);
            WriteLiteral("\r\n<h1>List Items</h1>\r\n\r\n");
            EndContext();
            BeginContext(120, 124, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Username</th>\r\n        <th>Email</th>\r\n        <th>Passwrod</th>\r\n    </tr>\r\n");
            EndContext();
#line 16 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/ViewUserData.cshtml"
     foreach (var user in Model)
    {

#line default
#line hidden
            BeginContext(285, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(316, 13, false);
#line 19 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/ViewUserData.cshtml"
           Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(329, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(353, 10, false);
#line 20 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/ViewUserData.cshtml"
           Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(363, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(387, 13, false);
#line 21 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/ViewUserData.cshtml"
           Write(user.Password);

#line default
#line hidden
            EndContext();
            BeginContext(400, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(424, 64, false);
#line 22 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/ViewUserData.cshtml"
           Write(Html.ActionLink("Add to Cart", "AddItemToCart", "Payment", user));

#line default
#line hidden
            EndContext();
            BeginContext(488, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 24 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/ViewUserData.cshtml"
    }

#line default
#line hidden
            BeginContext(517, 10, true);
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
