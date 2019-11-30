#pragma checksum "C:\Users\User\source\repos\Lab5\Lab8\Views\AcademicRecords\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76db756b0b2955041bfe65ceb94fd0f9bbf37ac7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AcademicRecords__ViewStart), @"mvc.1.0.view", @"/Views/AcademicRecords/_ViewStart.cshtml")]
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
#line 1 "C:\Users\User\source\repos\Lab5\Lab8\Views\_ViewImports.cshtml"
using Lab8;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Lab5\Lab8\Views\_ViewImports.cshtml"
using Lab8.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76db756b0b2955041bfe65ceb94fd0f9bbf37ac7", @"/Views/AcademicRecords/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54392077b573ca062b662c621eb32a31c11c50ef", @"/Views/_ViewImports.cshtml")]
    public class Views_AcademicRecords__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\source\repos\Lab5\Lab8\Views\AcademicRecords\_ViewStart.cshtml"
  
    List<TopMenuItem> topMenu = new List<TopMenuItem>();
    topMenu.Add(new TopMenuItem { AspAction = "Index", AspController = "Employees", DisplayText = "Employees" });
    topMenu.Add(new TopMenuItem { AspAction = "Index", AspController = "Students", DisplayText = "Students" });
    topMenu.Add(new TopMenuItem { AspAction = "Index", AspController = "Courses", DisplayText = "Courses" });

    ViewData["topMenu"] = topMenu;
    ViewData["Title"] = "AcademicRecord";
    Layout = "~/Views/Shared/_ACLayout.cshtml";

#line default
#line hidden
#nullable disable
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