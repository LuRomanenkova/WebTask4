#pragma checksum "C:\Users\LudmilaRomanenkova\RiderProjects\WebApplicationTask4\WebApplicationTask4\Views\Home\ShowBrand.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cc8457a89ac745d7ccd5d4a3472183c78acc522"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowBrand), @"mvc.1.0.view", @"/Views/Home/ShowBrand.cshtml")]
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
#line 1 "C:\Users\LudmilaRomanenkova\RiderProjects\WebApplicationTask4\WebApplicationTask4\Views\_ViewImports.cshtml"
using WebApplicationTask4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LudmilaRomanenkova\RiderProjects\WebApplicationTask4\WebApplicationTask4\Views\_ViewImports.cshtml"
using WebApplicationTask4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cc8457a89ac745d7ccd5d4a3472183c78acc522", @"/Views/Home/ShowBrand.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2fec16ea745e9f472bacdd04a032399b5a9beed", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowBrand : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplicationTask4.Models.Brand>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LudmilaRomanenkova\RiderProjects\WebApplicationTask4\WebApplicationTask4\Views\Home\ShowBrand.cshtml"
  
    ViewData["Title"] = "About Brand";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3><b>Information</b></h3>\r\n<table class=\"table-condensed\" cellpadding=\"15\" cellspacing=\"15\">\r\n    <tr>\r\n        <td>Brand</td>\r\n        <td>Country</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>");
#nullable restore
#line 13 "C:\Users\LudmilaRomanenkova\RiderProjects\WebApplicationTask4\WebApplicationTask4\Views\Home\ShowBrand.cshtml"
       Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 14 "C:\Users\LudmilaRomanenkova\RiderProjects\WebApplicationTask4\WebApplicationTask4\Views\Home\ShowBrand.cshtml"
       Write(ViewBag.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplicationTask4.Models.Brand>> Html { get; private set; }
    }
}
#pragma warning restore 1591
