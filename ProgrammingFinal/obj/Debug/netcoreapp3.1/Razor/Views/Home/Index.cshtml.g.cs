#pragma checksum "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "276869e4ad90334b9a3e130a4f2f63b639a62d0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\_ViewImports.cshtml"
using ProgrammingFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\_ViewImports.cshtml"
using ProgrammingFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"276869e4ad90334b9a3e130a4f2f63b639a62d0a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c26d0d3707daa506db40d13b3a44a8b9eb27ee97", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div data-aos=""fade-up"">
    <div class=""column"">
        <section class=""hero is-info welcome is-small is-fullwidth"">
            <div class=""hero-body"">
                <div class=""container"">
                    <h1 class=""title has-text-centered"">
                        Bienvenido al Sistema de Facturación.
                    </h1>
                    <h2 class=""subtitle has-text-centered"">
                        Creado por Karlyn Garcia Rojas
                    </h2>
                </div>
            </div>
        </section>
        <section class=""info-tiles"">
            <div class=""tile is-ancestor has-text-centered"">
                <div class=""tile is-parent"">
                    <article class=""tile is-child box"">
                        <p class=""title"">");
#nullable restore
#line 22 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\Home\Index.cshtml"
                                    Write(ViewBag.Products);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <p class=""subtitle"">Productos</p>
                    </article>
                </div>
                <div class=""tile is-parent"">
                    <article class=""tile is-child box"">
                        <p class=""title"">");
#nullable restore
#line 28 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\Home\Index.cshtml"
                                    Write(ViewBag.Clients);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <p class=""subtitle"">Clientes</p>
                    </article>
                </div>
                <div class=""tile is-parent"">
                    <article class=""tile is-child box"">
                        <p class=""title"">");
#nullable restore
#line 34 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\Home\Index.cshtml"
                                    Write(ViewBag.Vendor);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <p class=""subtitle"">Proveedores</p>
                    </article>
                </div>
                <div class=""tile is-parent"">
                    <article class=""tile is-child box"">
                        <p class=""title"">");
#nullable restore
#line 40 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\Home\Index.cshtml"
                                    Write(ViewBag.Billing);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <p class=""subtitle"">Facturas</p>
                    </article>
                </div>
            </div>
        </section>
        <div class=""columns"">
            <div class=""column"">
                <div class=""card events-card"">
                    <header class=""card-header"">
                        <p class=""card-header-title"">
                            Eventos
                        </p>
                        <a href=""#"" class=""card-header-icon"" aria-label=""more options"">
                            <span class=""icon"">
                                <i class=""fa fa-angle-down"" aria-hidden=""true""></i>
                            </span>
                        </a>
                    </header>
                    <div class=""card-table"">
                        <div class=""content"">
                            <table class=""table is-fullwidth is-striped"">
                                <tbody>
");
#nullable restore
#line 63 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\Home\Index.cshtml"
                                     foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td width=\"5%\"><i class=\"fa fa-bell-o\"></i></td>\r\n                                        <td>");
#nullable restore
#line 67 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\Home\Index.cshtml"
                                       Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 68 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\Home\Index.cshtml"
                                       Write(item.Entry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"level-right\"><a class=\"button is-small is-primary\" href=\"#\">Ver</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 71 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                    <footer class=""card-footer"">
                        <a href=""#"" class=""card-footer-item"">Ver todo</a>
                    </footer>
                </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591