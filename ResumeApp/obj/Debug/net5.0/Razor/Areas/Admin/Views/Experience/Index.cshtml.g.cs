#pragma checksum "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Areas\Admin\Views\Experience\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e003dd642840855f8f13cbea354a66755f511647"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Experience_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Experience/Index.cshtml")]
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
#line 1 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Areas\Admin\Views\_ViewImports.cshtml"
using ResumeApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Areas\Admin\Views\_ViewImports.cshtml"
using ResumeApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Areas\Admin\Views\_ViewImports.cshtml"
using ResumeApp.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Areas\Admin\Views\_ViewImports.cshtml"
using ResumeApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e003dd642840855f8f13cbea354a66755f511647", @"/Areas/Admin/Views/Experience/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4c2ec3a6c43332d7b7e3de207157b5f9f907a5b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Experience_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Areas\Admin\Views\Experience\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""table-responsive scrollbar"">
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">Year</th>
                <th class=""text-end"" scope=""col"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 18 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Areas\Admin\Views\Experience\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Areas\Admin\Views\Experience\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Areas\Admin\Views\Experience\Index.cshtml"
               Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-end\">\r\n                    <div>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 682, "\"", 720, 2);
            WriteAttributeValue("", 689, "/Admin/Experience/Edit/", 689, 23, true);
#nullable restore
#line 25 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Areas\Admin\Views\Experience\Index.cshtml"
WriteAttributeValue("", 712, item.Id, 712, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 781, "\"", 821, 2);
            WriteAttributeValue("", 788, "/Admin/Experience/Delete/", 788, 25, true);
#nullable restore
#line 26 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Areas\Admin\Views\Experience\Index.cshtml"
WriteAttributeValue("", 813, item.Id, 813, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Are you delete?\')\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Areas\Admin\Views\Experience\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; }
    }
}
#pragma warning restore 1591