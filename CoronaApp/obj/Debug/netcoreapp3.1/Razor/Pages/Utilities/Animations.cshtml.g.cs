#pragma checksum "C:\Users\bbdnet2135\Desktop\Grad\BBD-Csharp\CoronaAppthemedemo\CoronaApp\Pages\Utilities\Animations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7c3c4bbc59ec4003dcb27ff4f45eef8802c297a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoronaApp.Pages.Utilities.Pages_Utilities_Animations), @"mvc.1.0.razor-page", @"/Pages/Utilities/Animations.cshtml")]
namespace CoronaApp.Pages.Utilities
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
#line 1 "C:\Users\bbdnet2135\Desktop\Grad\BBD-Csharp\CoronaAppthemedemo\CoronaApp\Pages\_ViewImports.cshtml"
using CoronaApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c3c4bbc59ec4003dcb27ff4f45eef8802c297a", @"/Pages/Utilities/Animations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5ce40bf67042c924eb5fd75fc5f859a6f0151c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Utilities_Animations : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\bbdnet2135\Desktop\Grad\BBD-Csharp\CoronaAppthemedemo\CoronaApp\Pages\Utilities\Animations.cshtml"
  
    ViewData["Title"] = "Animations";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""h3 mb-1 text-gray-800"">Animation Utilities</h1>

<p class=""mb-4"">Bootstrap's default utility classes can be found on the official <a href=""https://getbootstrap.com/docs"">Bootstrap Documentation</a> page. The custom utilities below were created to extend this theme past the default utility classes built into Bootstrap's framework.</p>

<!-- Content Row -->
<div class=""row"">

    <!-- Grow In Utility -->
    <div class=""col-lg-6"">

        <div class=""card position-relative"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Grow In Animation Utilty</h6>
            </div>
            <div class=""card-body"">
                <div class=""mb-3"">
                    <code>.animated--grow-in</code>
                </div>
                <div class=""small mb-1"">Navbar Dropdown Example:</div>
                <nav class=""navbar navbar-expand navbar-light bg-light mb-4"">
                    <a class=""navbar-brand"" href=""#"">Navbar</a>");
            WriteLiteral(@"
                    <ul class=""navbar-nav ml-auto"">
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                Dropdown
                            </a>
                            <div class=""dropdown-menu dropdown-menu-right animated--grow-in"" aria-labelledby=""navbarDropdown"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                            </div>
                        </li>
                    </ul>
                </nav>
                <p class=""mb-0 small"">Note: This utility animates the CSS transform propert");
            WriteLiteral(@"y, meaning it will override any existing transforms on an element being animated! In this theme, the grow in animation is only being used on dropdowns within the navbar.</p>
            </div>
        </div>

    </div>

    <!-- Fade In Utility -->
    <div class=""col-lg-6"">

        <div class=""card position-relative"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Fade In Animation Utilty</h6>
            </div>
            <div class=""card-body"">
                <div class=""mb-3"">
                    <code>.animated--fade-in</code>
                </div>
                <div class=""small mb-1"">Navbar Dropdown Example:</div>
                <nav class=""navbar navbar-expand navbar-light bg-light mb-4"">
                    <a class=""navbar-brand"" href=""#"">Navbar</a>
                    <ul class=""navbar-nav ml-auto"">
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-tog");
            WriteLiteral(@"gle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                Dropdown
                            </a>
                            <div class=""dropdown-menu dropdown-menu-right animated--fade-in"" aria-labelledby=""navbarDropdown"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                            </div>
                        </li>
                    </ul>
                </nav>
                <div class=""small mb-1"">Dropdown Button Example:</div>
                <div class=""dropdown mb-4"">
                    <button class=""btn btn-primary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""");
            WriteLiteral(@"true"" aria-expanded=""false"">
                        Dropdown
                    </button>
                    <div class=""dropdown-menu animated--fade-in"" aria-labelledby=""dropdownMenuButton"">
                        <a class=""dropdown-item"" href=""#"">Action</a>
                        <a class=""dropdown-item"" href=""#"">Another action</a>
                        <a class=""dropdown-item"" href=""#"">Something else here</a>
                    </div>
                </div>
                <p class=""mb-0 small"">Note: This utility animates the CSS opacity property, meaning it will override any existing opacity on an element being animated!</p>
            </div>
        </div>

    </div>

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoronaApp.Pages.Utilities.AnimationsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoronaApp.Pages.Utilities.AnimationsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoronaApp.Pages.Utilities.AnimationsModel>)PageContext?.ViewData;
        public CoronaApp.Pages.Utilities.AnimationsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
