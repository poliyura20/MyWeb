#pragma checksum "D:\courses\MyWebApplicationCourses\MyWebApplicationCourses\Views\Shared\MetatagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c410b1ce12d06f0e663a42c72caaba6b4b832ea5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetatagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetatagsPartial.cshtml")]
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
#line 1 "D:\courses\MyWebApplicationCourses\MyWebApplicationCourses\Views\Shared\MetatagsPartial.cshtml"
using MyWebApplicationCourses.Service;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c410b1ce12d06f0e663a42c72caaba6b4b832ea5", @"/Views/Shared/MetatagsPartial.cshtml")]
    #nullable restore
    public class Views_Shared_MetatagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta charset=\"utf-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, user-scalable=no\" />\r\n");
#nullable restore
#line 4 "D:\courses\MyWebApplicationCourses\MyWebApplicationCourses\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<title>");
#nullable restore
#line 6 "D:\courses\MyWebApplicationCourses\MyWebApplicationCourses\Views\Shared\MetatagsPartial.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 7 "D:\courses\MyWebApplicationCourses\MyWebApplicationCourses\Views\Shared\MetatagsPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<title>");
#nullable restore
#line 10 "D:\courses\MyWebApplicationCourses\MyWebApplicationCourses\Views\Shared\MetatagsPartial.cshtml"
      Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 11 "D:\courses\MyWebApplicationCourses\MyWebApplicationCourses\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\courses\MyWebApplicationCourses\MyWebApplicationCourses\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 335, "\"", 365, 1);
#nullable restore
#line 14 "D:\courses\MyWebApplicationCourses\MyWebApplicationCourses\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 345, ViewBag.Description, 345, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 15 "D:\courses\MyWebApplicationCourses\MyWebApplicationCourses\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\courses\MyWebApplicationCourses\MyWebApplicationCourses\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Keywords != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 431, "\"", 458, 1);
#nullable restore
#line 18 "D:\courses\MyWebApplicationCourses\MyWebApplicationCourses\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 441, ViewBag.Keywords, 441, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 19 "D:\courses\MyWebApplicationCourses\MyWebApplicationCourses\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
