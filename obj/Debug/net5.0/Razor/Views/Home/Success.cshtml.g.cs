#pragma checksum "/Users/sujungchoi/Desktop/Coding/C#/4_ORM/LoginRegistration/Views/Home/Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ab3434710f739058b3f6e6eb743dc6d8b6394a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
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
#nullable restore
#line 1 "/Users/sujungchoi/Desktop/Coding/C#/4_ORM/LoginRegistration/Views/_ViewImports.cshtml"
using LoginRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sujungchoi/Desktop/Coding/C#/4_ORM/LoginRegistration/Views/_ViewImports.cshtml"
using LoginRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ab3434710f739058b3f6e6eb743dc6d8b6394a1", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58b8b69ac1923d039b18bb6580c27c9405e8eb6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\n    h1 {\n        margin: 190px auto;\n        color: forestgreen;\n        font-size: 50px;\n    }\n    h4 {\n        text-align: right;\n        margin: 30px;\n    }\n</style>\n");
#nullable restore
#line 12 "/Users/sujungchoi/Desktop/Coding/C#/4_ORM/LoginRegistration/Views/Home/Success.cshtml"
  
    ViewData["Title"] = "Success Page";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h4><a href=\"/logout\">Logout</a></h4>\n    <h1>S U C C E S S</h1>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591