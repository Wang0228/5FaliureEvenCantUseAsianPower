#pragma checksum "C:\Users\as258\Source\Repos\5FaliureEvenCantUseAsianPower\Mvc5_AI\About\Views\Shared\_loginStatusPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5589bd3ee8c98dc6c879ab212dd0b2e268c97324"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__loginStatusPartial), @"mvc.1.0.view", @"/Views/Shared/_loginStatusPartial.cshtml")]
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
#line 1 "C:\Users\as258\Source\Repos\5FaliureEvenCantUseAsianPower\Mvc5_AI\About\Views\_ViewImports.cshtml"
using About;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\as258\Source\Repos\5FaliureEvenCantUseAsianPower\Mvc5_AI\About\Views\_ViewImports.cshtml"
using About.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\as258\Source\Repos\5FaliureEvenCantUseAsianPower\Mvc5_AI\About\Views\_ViewImports.cshtml"
using About.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5589bd3ee8c98dc6c879ab212dd0b2e268c97324", @"/Views/Shared/_loginStatusPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e4b26e17d4270a6d196dd7edb9e53b199852e49", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__loginStatusPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul class=\"navbar-nav flex-grow-1\">\r\n");
#nullable restore
#line 2 "C:\Users\as258\Source\Repos\5FaliureEvenCantUseAsianPower\Mvc5_AI\About\Views\Shared\_loginStatusPartial.cshtml"
     if (User.Identity.IsAuthenticated)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a href=\"#\" class=\"btn btn-primary me-2\">");
#nullable restore
#line 5 "C:\Users\as258\Source\Repos\5FaliureEvenCantUseAsianPower\Mvc5_AI\About\Views\Shared\_loginStatusPartial.cshtml"
                                                Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n        <li>");
#nullable restore
#line 6 "C:\Users\as258\Source\Repos\5FaliureEvenCantUseAsianPower\Mvc5_AI\About\Views\Shared\_loginStatusPartial.cshtml"
       Write(Html.ActionLink("登出", "Index","Users", null, new { @class="btn btn-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 7 "C:\Users\as258\Source\Repos\5FaliureEvenCantUseAsianPower\Mvc5_AI\About\Views\Shared\_loginStatusPartial.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 336, "\"", 372, 1);
#nullable restore
#line 11 "C:\Users\as258\Source\Repos\5FaliureEvenCantUseAsianPower\Mvc5_AI\About\Views\Shared\_loginStatusPartial.cshtml"
WriteAttributeValue("", 343, Url.Action("Login", "Users"), 343, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary me-2\">登入</a></li>\r\n        <li><a");
            BeginWriteAttribute("href", " href=\"", 430, "\"", 467, 1);
#nullable restore
#line 12 "C:\Users\as258\Source\Repos\5FaliureEvenCantUseAsianPower\Mvc5_AI\About\Views\Shared\_loginStatusPartial.cshtml"
WriteAttributeValue("", 437, Url.Action("Create", "Users"), 437, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">註冊</a></li>\r\n");
#nullable restore
#line 13 "C:\Users\as258\Source\Repos\5FaliureEvenCantUseAsianPower\Mvc5_AI\About\Views\Shared\_loginStatusPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
