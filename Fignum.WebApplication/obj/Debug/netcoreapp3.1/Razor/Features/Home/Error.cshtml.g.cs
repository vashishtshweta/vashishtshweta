#pragma checksum "C:\Users\shaveta.vashisht\source\repos\Fignum.WebApplication\Fignum.WebApplication\Features\Home\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3e40c1308591ae055a2f10c2f0517e9e64593e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Features_Home_Error), @"mvc.1.0.view", @"/Features/Home/Error.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3e40c1308591ae055a2f10c2f0517e9e64593e7", @"/Features/Home/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Features/_ViewImports.cshtml")]
    public class Features_Home_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fignum.WebApplication.Features.Home.Models.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\shaveta.vashisht\source\repos\Fignum.WebApplication\Fignum.WebApplication\Features\Home\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-xl-2 d-xl-block d-lg-none""></div>
    <div class=""col-xl-8"">
        <div class=""row"">
            <div class=""col"">
                <div class=""alert alert-danger"" role=""alert"">
                    <i class=""fa fa-info-circle mr-2""></i>
                    ");
#nullable restore
#line 12 "C:\Users\shaveta.vashisht\source\repos\Fignum.WebApplication\Fignum.WebApplication\Features\Home\Error.cshtml"
               Write(Model.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-xl-2 d-xl-block d-lg-none\"></div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fignum.WebApplication.Features.Home.Models.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
