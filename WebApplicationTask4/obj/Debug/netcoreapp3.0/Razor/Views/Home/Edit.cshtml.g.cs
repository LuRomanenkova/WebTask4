#pragma checksum "C:\Users\LudmilaRomanenkova\RiderProjects\WebApplicationTask4\WebApplicationTask4\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11018476257d7457fc927bd5a49c898fdb3f2406"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11018476257d7457fc927bd5a49c898fdb3f2406", @"/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2fec16ea745e9f472bacdd04a032399b5a9beed", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LudmilaRomanenkova\RiderProjects\WebApplicationTask4\WebApplicationTask4\Views\Home\Edit.cshtml"
  
    ViewData["Title"] = "Edit Perfume";

#line default
#line hidden
#nullable disable
            WriteLiteral(" <html>\r\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11018476257d7457fc927bd5a49c898fdb3f24064819", async() => {
                WriteLiteral("\r\n     <meta name=\"viewport\" content=\"width=device-width\" />\r\n     <title>Edit Perfume</title>\r\n ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11018476257d7457fc927bd5a49c898fdb3f24065889", async() => {
                WriteLiteral("\r\n ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11018476257d7457fc927bd5a49c898fdb3f24066148", async() => {
                    WriteLiteral("\r\n     <input type=\"hidden\"");
                    BeginWriteAttribute("value", " value=\"", 263, "\"", 282, 1);
#nullable restore
#line 11 "C:\Users\LudmilaRomanenkova\RiderProjects\WebApplicationTask4\WebApplicationTask4\Views\Home\Edit.cshtml"
WriteAttributeValue("", 271, ViewBag.Id, 271, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" name=""Id"" />
     <p>Fill the fields for editing perfume data:</p>
     <div class=""form-group"">
         <label for=""Name"" class=""col-md-2 control-label"">Name:</label>
         <div class=""col-md-4"">
             <input type=""text"" name=""Name"" class=""form-control""");
                    BeginWriteAttribute("value", " value=\"", 554, "\"", 575, 1);
#nullable restore
#line 16 "C:\Users\LudmilaRomanenkova\RiderProjects\WebApplicationTask4\WebApplicationTask4\Views\Home\Edit.cshtml"
WriteAttributeValue("", 562, ViewBag.Name, 562, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n         </div>\r\n     </div>\r\n     <div class=\"form-group\">\r\n         <label for=\"Price\" class=\"col-md-2 control-label\">Price:</label>\r\n         <div class=\"col-md-4\">\r\n             <input type=\"text\" name=\"Price\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 813, "\"", 835, 1);
#nullable restore
#line 22 "C:\Users\LudmilaRomanenkova\RiderProjects\WebApplicationTask4\WebApplicationTask4\Views\Home\Edit.cshtml"
WriteAttributeValue("", 821, ViewBag.Price, 821, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("/>\r\n         </div>\r\n     </div>\r\n     <div class=\"form-group\">\r\n         <label for=\"Volume\" class=\"col-md-2 control-label\">Volume:</label>\r\n         <div class=\"col-md-4\">\r\n             <input type=\"text\" name=\"Volume\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 1077, "\"", 1100, 1);
#nullable restore
#line 28 "C:\Users\LudmilaRomanenkova\RiderProjects\WebApplicationTask4\WebApplicationTask4\Views\Home\Edit.cshtml"
WriteAttributeValue("", 1085, ViewBag.Volume, 1085, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("/>\r\n         </div>\r\n     </div>\r\n     <div class=\"form-group\">\r\n         <label for=\"Count\" class=\"col-md-2 control-label\">Available: </label>\r\n         <div class=\"col-md-4\">\r\n             <input type=\"text\" name=\"Count\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 1344, "\"", 1367, 1);
#nullable restore
#line 34 "C:\Users\LudmilaRomanenkova\RiderProjects\WebApplicationTask4\WebApplicationTask4\Views\Home\Edit.cshtml"
WriteAttributeValue(" ", 1352, ViewBag.Count, 1353, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("/>\r\n         </div>\r\n     </div>\r\n     <div class=\"form-group\">\r\n          <label for=\"Brand\" class=\"col-md-2 control-label\">Brand:</label>\r\n          <div class=\"col-md-4\">\r\n              <input type=\"text\" name=\"Brand\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 1609, "\"", 1631, 1);
#nullable restore
#line 40 "C:\Users\LudmilaRomanenkova\RiderProjects\WebApplicationTask4\WebApplicationTask4\Views\Home\Edit.cshtml"
WriteAttributeValue("", 1617, ViewBag.Brand, 1617, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n          </div>\r\n      </div>\r\n     <div class=\"form-group\">\r\n         <div class=\"col-md-offset-2 col-md-10\">\r\n");
                    WriteLiteral(@"             <span class=""col-md-offset-2 col-md-10"">
                 <button type=""submit"" value=""Submit"" name=""Submit"">Submit</button>                
                 <button type=""submit""  value=""Cancel"" name=""Cancel"">Cancel</button>
             </span>
         </div>
     </div>
 ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n <html>\r\n");
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
