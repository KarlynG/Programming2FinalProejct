#pragma checksum "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\TablesEdit\VendorEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfcb6c1cd962d7849f826201a80c581496a000bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TablesEdit_VendorEdit), @"mvc.1.0.view", @"/Views/TablesEdit/VendorEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfcb6c1cd962d7849f826201a80c581496a000bf", @"/Views/TablesEdit/VendorEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c26d0d3707daa506db40d13b3a44a8b9eb27ee97", @"/Views/_ViewImports.cshtml")]
    public class Views_TablesEdit_VendorEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("VendorEdit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\TablesEdit\VendorEdit.cshtml"
  
    ViewData["Title"] = "Editar Proveedor";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""has-text-centered"">
    <br /><br />
    <h1 class=""title"" data-aos=""zoom-out"">Escriba los nuevos datos del Proveedor</h1>
</div>
<br />
<br />
<div class=""card"" data-aos=""fade-up"" data-aos-delay=""200"">
    <div class=""card-content"">
        <div class=""content"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfcb6c1cd962d7849f826201a80c581496a000bf4845", async() => {
                WriteLiteral("\r\n                <div class=\"columns\">\r\n                    <div class=\"column\">\r\n                        <div class=\"field\">\r\n                            <input class=\"input\" type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 619, "\"", 636, 1);
#nullable restore
#line 17 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\TablesEdit\VendorEdit.cshtml"
WriteAttributeValue("", 627, Model.Id, 627, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            <label class=""label"">Nombre del Proveedor</label>
                            <div class=""control"">
                                <input class=""input""
                                       type=""text""
                                       placeholder=""Nombre""
                                       name=""name""");
                BeginWriteAttribute("value", "\r\n                                       value=\"", 987, "\"", 1046, 1);
#nullable restore
#line 24 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\TablesEdit\VendorEdit.cshtml"
WriteAttributeValue("", 1035, Model.Name, 1035, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                    <div class=""column"">
                        <div class=""field"">
                            <label class=""label"">Numero de telefono</label>
                            <div class=""control"">
                                <input class=""input"" 
                                       type=""text"" 
                                       placeholder=""Numero de telefono"" 
                                       name=""phoneNumber"" 
                                       maxlength=""9""");
                BeginWriteAttribute("value", " \r\n                                       value=\"", 1655, "\"", 1722, 1);
#nullable restore
#line 37 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\TablesEdit\VendorEdit.cshtml"
WriteAttributeValue("", 1704, Model.PhoneNumber, 1704, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""columns"">
                    <div class=""column"">
                        <div class=""field"">
                            <label class=""label"">Email del Proveedor</label>
                            <div class=""control"">
                                <input class=""input"" 
                                       type=""text"" 
                                       placeholder=""Correo electronico"" 
                                       name=""email""");
                BeginWriteAttribute("value", " \r\n                                       value=\"", 2334, "\"", 2395, 1);
#nullable restore
#line 51 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\TablesEdit\VendorEdit.cshtml"
WriteAttributeValue("", 2383, Model.email, 2383, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                    <div class=""column"">
                        <div class=""field"">
                            <label class=""label"">Cedula</label>
                            <div class=""control"">
                                <input class=""input"" 
                                       type=""text"" 
                                       placeholder=""Cedula"" 
                                       name=""document"" 
                                       maxlength=""9""");
                BeginWriteAttribute("value", " \r\n                                       value=\"", 2977, "\"", 3041, 1);
#nullable restore
#line 64 "C:\Users\karly\source\repos\ProgrammingFinal\ProgrammingFinal\Views\TablesEdit\VendorEdit.cshtml"
WriteAttributeValue("", 3026, Model.Document, 3026, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <button class=\"button is-large is-fullwidth\">Enviar</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
