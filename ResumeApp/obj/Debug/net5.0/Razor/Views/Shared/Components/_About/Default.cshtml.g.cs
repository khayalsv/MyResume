#pragma checksum "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00ba53dbcf1db76ea7ac51579f9863349516598f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__About_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_About/Default.cshtml")]
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
#line 1 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\_ViewImports.cshtml"
using ResumeApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\_ViewImports.cshtml"
using ResumeApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\_ViewImports.cshtml"
using ResumeApp.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\_ViewImports.cshtml"
using ResumeApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00ba53dbcf1db76ea7ac51579f9863349516598f", @"/Views/Shared/Components/_About/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4c2ec3a6c43332d7b7e3de207157b5f9f907a5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__About_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ALLVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""cavani_tm_section"" id=""about"">
    <div class=""section_inner"">
        <div class=""cavani_tm_about"">
            <div class=""biography"">
                <div class=""cavani_tm_title"">
                    <span>Khayal Salimov</span>
                </div>
                <div class=""wrapper"">
");
#nullable restore
#line 12 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                     foreach (var item in Model.Abouts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"left\">\n            <p>");
#nullable restore
#line 15 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
          Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n                        <div class=\"right\">\n                            <ul>\n                                <li><span class=\"first\">Name:</span><span class=\"second\">");
#nullable restore
#line 19 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                                <li><span class=\"first\">Address:</span><span class=\"second\">");
#nullable restore
#line 20 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                                                                       Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                                <li><span class=\"first\">Mail:</span><span class=\"second\">");
#nullable restore
#line 21 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                                                                    Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                                <li><span class=\"first\">Phone:</span><span class=\"second\">");
#nullable restore
#line 22 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                                                                     Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                            </ul>\n                        </div>");
#nullable restore
#line 24 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>


            <div class=""services"">
            <div class=""wrapper"">
                <div class=""service_list"">
                    <div class=""cavani_tm_title"">
                        <span>Services</span>
                    </div>
                    <div class=""list"">
                        <ul>
");
#nullable restore
#line 37 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                             foreach (var item in Model.Services)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 39 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 40 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
        </div>
            <div class=""skills"">
                <div class=""wrapper"">
                    <div class=""programming"">
                        <div class=""cavani_tm_title"">
                            <span>Programming</span>
                        </div>
                        <div class=""cavani_progress"">
");
#nullable restore
#line 53 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                             foreach (var item in Model.Programmings)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"progress_inner\" data-value=\"");
#nullable restore
#line 55 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                                                   Write(item.Percent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                                    <span><span class=\"label\">");
#nullable restore
#line 56 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"number\">");
#nullable restore
#line 56 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                                                                               Write(item.Percent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span></span>\n                                    <div class=\"background\"><div class=\"bar\"><div class=\"bar_in\"></div></div></div>\n                                </div>\n");
#nullable restore
#line 59 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                    <div class=""language"">
                        <div class=""cavani_tm_title"">
                            <span>Language</span>
                        </div>
                        <div class=""circular_progress_bar"">
                            <ul>
");
#nullable restore
#line 68 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                 foreach (var item in Model.Languages)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\n                                        <div class=\"list_inner\">\n                                            <div class=\"myCircle\" data-value=\"0.");
#nullable restore
#line 72 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                                                           Write(item.Percent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></div>\n                                            <div class=\"title\"><span>");
#nullable restore
#line 73 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\n                                        </div>\n                                    </li>\n");
#nullable restore
#line 76 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""resume"">
                <div class=""wrapper"">
                    <div class=""education"">
                        <div class=""cavani_tm_title"">
                            <span>Education</span>
                        </div>
                        <div class=""list"">
                            <div class=""univ"">
                                <ul>
");
#nullable restore
#line 91 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                     foreach (var item in Model.Educations)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>\n                                            <div class=\"list_inner\">\n                                                <div class=\"time\">\n                                                    <span>");
#nullable restore
#line 96 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                                     Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                                </div>\n                                                <div class=\"place\">\n                                                    <h3>");
#nullable restore
#line 99 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                                                </div>\n                                            </div>\n                                        </li>\n");
#nullable restore
#line 103 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""experience"">
                        <div class=""cavani_tm_title"">
                            <span>Experience</span>
                        </div>
                        <div class=""list"">
                            <div class=""univ"">
                                <ul>
");
#nullable restore
#line 115 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                     foreach (var item in Model.Experiences)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>\n                                            <div class=\"list_inner\">\n                                                <div class=\"time\">\n                                                    <span>");
#nullable restore
#line 120 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                                     Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                                </div>\n                                                <div class=\"place\">\n                                                    <h3>");
#nullable restore
#line 123 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                                                </div>\n                                            </div>\n                                        </li>\n");
#nullable restore
#line 127 "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Views\Shared\Components\_About\Default.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ALLVM> Html { get; private set; }
    }
}
#pragma warning restore 1591