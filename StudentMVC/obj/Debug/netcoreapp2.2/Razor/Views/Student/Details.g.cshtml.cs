#pragma checksum "E:\ProjectNET\StudentMVC\StudentMVC\Views\Student\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be38b7ab3028422b772bc1084918b856798f65e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Details), @"mvc.1.0.view", @"/Views/Student/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Details.cshtml", typeof(AspNetCore.Views_Student_Details))]
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
#line 1 "E:\ProjectNET\StudentMVC\StudentMVC\Views\_ViewImports.cshtml"
using StudentMVC;

#line default
#line hidden
#line 2 "E:\ProjectNET\StudentMVC\StudentMVC\Views\_ViewImports.cshtml"
using StudentMVC.Models;

#line default
#line hidden
#line 3 "E:\ProjectNET\StudentMVC\StudentMVC\Views\_ViewImports.cshtml"
using StudentMVC.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be38b7ab3028422b772bc1084918b856798f65e6", @"/Views/Student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09e4e491acaea35e85d16125424bcb271d84ebb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\ProjectNET\StudentMVC\StudentMVC\Views\Student\Details.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(60, 69, true);
            WriteLiteral("\r\n<h1>Detail</h1>\r\n\r\n<div class=\"thumbnail\">\r\n    <img id=\"imgDetail\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 129, "\"", 146, 1);
#line 10 "E:\ProjectNET\StudentMVC\StudentMVC\Views\Student\Details.cshtml"
WriteAttributeValue("", 135, Model.Name, 135, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 147, "\"", 168, 1);
#line 10 "E:\ProjectNET\StudentMVC\StudentMVC\Views\Student\Details.cshtml"
WriteAttributeValue("", 153, Model.UrlImage, 153, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(169, 66, true);
            WriteLiteral(">\r\n    <div class=\"caption-full\">\r\n        <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(236, 9, false);
#line 12 "E:\ProjectNET\StudentMVC\StudentMVC\Views\Student\Details.cshtml"
                          Write(Model.Sex);

#line default
#line hidden
            EndContext();
            BeginContext(245, 45, true);
            WriteLiteral("</h3>\r\n        <h3>\r\n            <a href=\"#\">");
            EndContext();
            BeginContext(291, 10, false);
#line 14 "E:\ProjectNET\StudentMVC\StudentMVC\Views\Student\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(301, 33, true);
            WriteLiteral("</a>\r\n        </h3>\r\n        <h4>");
            EndContext();
            BeginContext(335, 21, false);
#line 16 "E:\ProjectNET\StudentMVC\StudentMVC\Views\Student\Details.cshtml"
       Write(Model.Group.GroupName);

#line default
#line hidden
            EndContext();
            BeginContext(356, 18, true);
            WriteLiteral("</h4>\r\n        <p>");
            EndContext();
            BeginContext(375, 13, false);
#line 17 "E:\ProjectNET\StudentMVC\StudentMVC\Views\Student\Details.cshtml"
      Write(Model.History);

#line default
#line hidden
            EndContext();
            BeginContext(388, 28, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591