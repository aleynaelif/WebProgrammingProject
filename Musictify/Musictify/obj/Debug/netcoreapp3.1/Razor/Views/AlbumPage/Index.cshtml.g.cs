#pragma checksum "C:\Users\aleyn\Desktop\WebProgrammingProject\Musictify\Musictify\Views\AlbumPage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d95301d445c6f1e0b069b67478f6e593542b893e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AlbumPage_Index), @"mvc.1.0.view", @"/Views/AlbumPage/Index.cshtml")]
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
#line 1 "C:\Users\aleyn\Desktop\WebProgrammingProject\Musictify\Musictify\Views\_ViewImports.cshtml"
using Musictify;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aleyn\Desktop\WebProgrammingProject\Musictify\Musictify\Views\_ViewImports.cshtml"
using Musictify.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d95301d445c6f1e0b069b67478f6e593542b893e", @"/Views/AlbumPage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0873adb2bc3c06e87521615ef623657f2d96c1ed", @"/Views/_ViewImports.cshtml")]
    public class Views_AlbumPage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Musictify.Models.Album>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <style>
        body {
            font-family: Helvetica, sans-serif;
            background-color: #252526;
            color: rgb(202 207 187);
        }
    </style>
    <!-- Latest Albums-->
    <section class=""py-5"">
        <div class=""container px-5 my-5"">
            <div class=""text-center mb-5"">
                <h1 class=""h1 fw-bolder text"">Albümler</h1>
                <br />
            </div>
            <div class=""row gx-6"">

");
#nullable restore
#line 18 "C:\Users\aleyn\Desktop\WebProgrammingProject\Musictify\Musictify\Views\AlbumPage\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3\">\r\n                        <div class=\"position-relative mb-5\">\r\n                            <img class=\"img-fluid rounded-3 mb-3\"");
            BeginWriteAttribute("src", " src=", 746, "", 795, 1);
#nullable restore
#line 22 "C:\Users\aleyn\Desktop\WebProgrammingProject\Musictify\Musictify\Views\AlbumPage\Index.cshtml"
WriteAttributeValue("", 751, Html.DisplayFor(modelItem => item.ImageUrl), 751, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"300\">\r\n                            <center><a class=\"h4 text-white-50 fw-bolder text-decoration-none link-dark stretched-link\" href=\"#!\">");
#nullable restore
#line 23 "C:\Users\aleyn\Desktop\WebProgrammingProject\Musictify\Musictify\Views\AlbumPage\Index.cshtml"
                                                                                                                             Write(Html.DisplayFor(modelItem => item.AlbumName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></center>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 26 "C:\Users\aleyn\Desktop\WebProgrammingProject\Musictify\Musictify\Views\AlbumPage\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n    </section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Musictify.Models.Album>> Html { get; private set; }
    }
}
#pragma warning restore 1591