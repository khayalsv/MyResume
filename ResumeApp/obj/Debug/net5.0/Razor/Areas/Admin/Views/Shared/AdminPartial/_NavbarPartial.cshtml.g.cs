#pragma checksum "C:\Users\selim\Desktop\Programming\Resume\ResumeApp\Areas\Admin\Views\Shared\AdminPartial\_NavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf582fbea24eb13eb6e3e5ce31c0c4a14031325c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_AdminPartial__NavbarPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/AdminPartial/_NavbarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf582fbea24eb13eb6e3e5ce31c0c4a14031325c", @"/Areas/Admin/Views/Shared/AdminPartial/_NavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4c2ec3a6c43332d7b7e3de207157b5f9f907a5b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_AdminPartial__NavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("me-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/assets/img/ks.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""navbar navbar-light navbar-vertical navbar-expand-xl"" style=""display: none;"">
    <script>
                    var navbarStyle = localStorage.getItem(""navbarStyle"");
                    if (navbarStyle && navbarStyle !== 'transparent') {
                        document.querySelector('.navbar-vertical').classList.add(`navbar-${navbarStyle}`);
                    }</script>
    <div class=""d-flex align-items-center"">
        <div class=""toggle-icon-wrapper"">
            <button class=""btn navbar-toggler-humburger-icon navbar-vertical-toggle"" data-bs-toggle=""tooltip"" data-bs-placement=""left"" title=""Toggle Navigation""><span class=""navbar-toggle-icon""><span class=""toggle-line""></span></span></button>
        </div><a class=""navbar-brand"" href=""/"">
            <div class=""d-flex align-items-center py-3""><span class=""font-sans-serif"">KS</span></div>
        </a>
    </div>
    <div class=""collapse navbar-collapse"" id=""navbarVerticalCollapse"">
        <div class=""navbar-vertical-content scr");
            WriteLiteral(@"ollbar"">
            <ul class=""navbar-nav flex-column mb-3"" id=""navbarVerticalNav"">
                <li class=""nav-item"">
                    <!-- label-->
                    <div class=""row navbar-vertical-label-wrapper mt-3 mb-2"">
                        <div class=""col-auto navbar-vertical-label"">Admin</div>
                        <div class=""col ps-0"">
                            <hr class=""mb-0 navbar-vertical-divider"" />
                        </div>
                    </div>
                    <!-- parent pages-->
                    <!-- parent pages-->
                    <a class=""nav-link dropdown-indicator"" href=""#home"" role=""button"" data-bs-toggle=""collapse"" aria-expanded=""false"" aria-controls=""home"">
                        <div class=""d-flex align-items-center""><span class=""nav-link-icon""><span class=""far fa-address-card""></span></span><span class=""nav-link-text ps-1"">Home</span></div>
                    </a>
                    <ul class=""nav collapse"" id=""home"">
       ");
            WriteLiteral(@"                 <li class=""nav-item"">
                            <a class=""nav-link"" href=""/admin/home/index"" data-bs-toggle="""" aria-expanded=""false"">
                                <div class=""d-flex align-items-center""><span class=""nav-link-text ps-1"">List</span></div>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/admin/home/create"" data-bs-toggle="""" aria-expanded=""false"">
                                <div class=""d-flex align-items-center""><span class=""nav-link-text ps-1"">Create</span></div>
                            </a>
                        </li>
                    </ul>
                    <!-- parent pages-->
                    <!-- parent pages-->
                    <a class=""nav-link dropdown-indicator"" href=""#About"" role=""button"" data-bs-toggle=""collapse"" aria-expanded=""false"" aria-controls=""About"">
                        <div class=""d-flex align-items-cen");
            WriteLiteral(@"ter""><span class=""nav-link-icon""><span class=""far fa-chart-bar""></span></span><span class=""nav-link-text ps-1"">About</span></div>
                    </a>
                    <ul class=""nav collapse"" id=""About"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/admin/About/index"" data-bs-toggle="""" aria-expanded=""false"">
                                <div class=""d-flex align-items-center""><span class=""nav-link-text ps-1"">List</span></div>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/admin/About/create"" data-bs-toggle="""" aria-expanded=""false"">
                                <div class=""d-flex align-items-center""><span class=""nav-link-text ps-1"">Create</span></div>
                            </a>
                        </li>
                    </ul>
                    <!-- parent pages-->
                    <!-- parent pag");
            WriteLiteral(@"es-->
                    <a class=""nav-link dropdown-indicator"" href=""#Education"" role=""button"" data-bs-toggle=""collapse"" aria-expanded=""false"" aria-controls=""Education"">
                        <div class=""d-flex align-items-center""><span class=""nav-link-icon""><span class=""far fa-comment-alt""></span></span><span class=""nav-link-text ps-1"">Education</span></div>
                    </a>
                    <ul class=""nav collapse"" id=""Education"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/admin/Education/index"" data-bs-toggle="""" aria-expanded=""false"">
                                <div class=""d-flex align-items-center""><span class=""nav-link-text ps-1"">List</span></div>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/admin/Education/create"" data-bs-toggle="""" aria-expanded=""false"">
                                <div class=""");
            WriteLiteral(@"d-flex align-items-center""><span class=""nav-link-text ps-1"">Create</span></div>
                            </a>
                        </li>
                    </ul>
                    <!-- parent pages-->
                    <!-- parent pages-->
                    <a class=""nav-link dropdown-indicator"" href=""#Experience"" role=""button"" data-bs-toggle=""collapse"" aria-expanded=""false"" aria-controls=""Experience"">
                        <div class=""d-flex align-items-center""><span class=""nav-link-icon""><span class=""far fa-clipboard""></span></span><span class=""nav-link-text ps-1"">Experience</span></div>
                    </a>
                    <ul class=""nav collapse"" id=""Experience"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/admin/Experience/index"" data-bs-toggle="""" aria-expanded=""false"">
                                <div class=""d-flex align-items-center""><span class=""nav-link-text ps-1"">List</span></div>
                        ");
            WriteLiteral(@"    </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/admin/Experience/create"" data-bs-toggle="""" aria-expanded=""false"">
                                <div class=""d-flex align-items-center""><span class=""nav-link-text ps-1"">Create</span></div>
                            </a>
                        </li>
                    </ul>
                    <!-- parent pages-->
                    <!-- parent pages-->
                    <a class=""nav-link dropdown-indicator"" href=""#Language"" role=""button"" data-bs-toggle=""collapse"" aria-expanded=""false"" aria-controls=""Language"">
                        <div class=""d-flex align-items-center""><span class=""nav-link-icon""><span class=""far fa-eye""></span></span><span class=""nav-link-text ps-1"">Language</span></div>
                    </a>
                    <ul class=""nav collapse"" id=""Language"">
                        <li class=""nav-item"">
                            ");
            WriteLiteral(@"<a class=""nav-link"" href=""/admin/Language/Index"" data-bs-toggle="""" aria-expanded=""false"">
                                <div class=""d-flex align-items-center""><span class=""nav-link-text ps-1"">List</span></div>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/admin/Language/create"" data-bs-toggle="""" aria-expanded=""false"">
                                <div class=""d-flex align-items-center""><span class=""nav-link-text ps-1"">Create</span></div>
                            </a>
                        </li>
                    </ul>
                    <!-- parent pages-->
                    <!-- parent pages-->
                    <a class=""nav-link dropdown-indicator"" href=""#Portfolio"" role=""button"" data-bs-toggle=""collapse"" aria-expanded=""false"" aria-controls=""Portfolio"">
                        <div class=""d-flex align-items-center""><span class=""nav-link-icon""><span class=""far fa");
            WriteLiteral(@"-file-archive""></span></span><span class=""nav-link-text ps-1"">Portfolio</span></div>
                    </a>
                    <ul class=""nav collapse"" id=""Portfolio"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/admin/Portfolio/Index"" data-bs-toggle="""" aria-expanded=""false"">
                                <div class=""d-flex align-items-center""><span class=""nav-link-text ps-1"">List</span></div>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/admin/Portfolio/create"" data-bs-toggle="""" aria-expanded=""false"">
                                <div class=""d-flex align-items-center""><span class=""nav-link-text ps-1"">Create</span></div>
                            </a>
                        </li>
                    </ul>
                    <!-- parent pages-->
                    <!-- parent pages-->
                    <a cla");
            WriteLiteral(@"ss=""nav-link dropdown-indicator"" href=""#Programming"" role=""button"" data-bs-toggle=""collapse"" aria-expanded=""false"" aria-controls=""Programming"">
                        <div class=""d-flex align-items-center""><span class=""nav-link-icon""><span class=""far fa-flag""></span></span><span class=""nav-link-text ps-1"">Programming</span></div>
                    </a>
                    <ul class=""nav collapse"" id=""Programming"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/admin/Programming/Index"" data-bs-toggle="""" aria-expanded=""false"">
                                <div class=""d-flex align-items-center""><span class=""nav-link-text ps-1"">List</span></div>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/admin/Programming/create"" data-bs-toggle="""" aria-expanded=""false"">
                                <div class=""d-flex align-items-center""><");
            WriteLiteral(@"span class=""nav-link-text ps-1"">Create</span></div>
                            </a>
                        </li>
                    </ul>
                    <!-- parent pages-->
                    <!-- parent pages-->
                    <a class=""nav-link dropdown-indicator"" href=""#Services"" role=""button"" data-bs-toggle=""collapse"" aria-expanded=""false"" aria-controls=""Counter"">
                        <div class=""d-flex align-items-center""><span class=""nav-link-icon""><span class=""far fa-hourglass""></span></span><span class=""nav-link-text ps-1"">Services</span></div>
                    </a>
                    <ul class=""nav collapse"" id=""Services"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/admin/Services/Index"" data-bs-toggle="""" aria-expanded=""false"">
                                <div class=""d-flex align-items-center""><span class=""nav-link-text ps-1"">List</span></div>
                            </a>
                        </li>");
            WriteLiteral(@"
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/admin/Services/create"" data-bs-toggle="""" aria-expanded=""false"">
                                <div class=""d-flex align-items-center""><span class=""nav-link-text ps-1"">Create</span></div>
                            </a>
                        </li>
                    </ul>

                </li>
            </ul>
        </div>
    </div>
</nav>
<nav class=""navbar navbar-light navbar-glass navbar-top navbar-expand-xl"" style=""display: none;"">
    <button class=""btn navbar-toggler-humburger-icon navbar-toggler me-1 me-sm-3"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarStandard"" aria-controls=""navbarStandard"" aria-expanded=""false"" aria-label=""Toggle Navigation""><span class=""navbar-toggle-icon""><span class=""toggle-line""></span></span></button>
    <a class=""navbar-brand me-1 me-sm-3"" href=""/"">
        <div class=""d-flex align-items-center"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf582fbea24eb13eb6e3e5ce31c0c4a14031325c18177", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<span class=\"font-sans-serif\">KS</span></div>\r\n    </a>\r\n\r\n\r\n</nav>");
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
