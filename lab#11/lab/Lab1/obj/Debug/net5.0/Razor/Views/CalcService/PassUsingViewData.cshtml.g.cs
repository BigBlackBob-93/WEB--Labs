#pragma checksum "D:\C++\5 semester\h\Lab1\Views\CalcService\PassUsingViewData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38144c3ad08c5515422914cdf9f289c422a44ae2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CalcService_PassUsingViewData), @"mvc.1.0.view", @"/Views/CalcService/PassUsingViewData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38144c3ad08c5515422914cdf9f289c422a44ae2", @"/Views/CalcService/PassUsingViewData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CalcService_PassUsingViewData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\C++\5 semester\h\Lab1\Views\CalcService\PassUsingViewData.cshtml"
  
    ViewBag.Title = "PassUsingViewData - Backend1";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>PassUsingViewBag</h1>\r\n<b>Rand value first:</b> ");
#nullable restore
#line 5 "D:\C++\5 semester\h\Lab1\Views\CalcService\PassUsingViewData.cshtml"
                    Write(ViewData["X"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n<b>Rand value second:</b> ");
#nullable restore
#line 6 "D:\C++\5 semester\h\Lab1\Views\CalcService\PassUsingViewData.cshtml"
                     Write(ViewData["Y"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n\r\n<b>Add:</b><br/>\r\n");
#nullable restore
#line 9 "D:\C++\5 semester\h\Lab1\Views\CalcService\PassUsingViewData.cshtml"
Write(ViewData["Sum"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n\r\n<b>Dif:</b><br/>\r\n");
#nullable restore
#line 12 "D:\C++\5 semester\h\Lab1\Views\CalcService\PassUsingViewData.cshtml"
Write(ViewData["Dif"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n\r\n<b>Mult:</b><br/>\r\n");
#nullable restore
#line 15 "D:\C++\5 semester\h\Lab1\Views\CalcService\PassUsingViewData.cshtml"
Write(ViewData["Mult"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n\r\n<b>Div:</b><br/>\r\n");
#nullable restore
#line 18 "D:\C++\5 semester\h\Lab1\Views\CalcService\PassUsingViewData.cshtml"
Write(ViewData["Div"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n");
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