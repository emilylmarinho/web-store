#pragma checksum "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\Produtos\AddEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a535189c4677fa0e4ce5897abc7fe9d609c69f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_AddEdit), @"mvc.1.0.view", @"/Views/Produtos/AddEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produtos/AddEdit.cshtml", typeof(AspNetCore.Views_Produtos_AddEdit))]
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
#line 1 "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\_ViewImports.cshtml"
using firstStore.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a535189c4677fa0e4ce5897abc7fe9d609c69f0", @"/Views/Produtos/AddEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a44defe9f23c092d1eab9f4a48d99556ae6f6b4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_AddEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\Produtos\AddEdit.cshtml"
   
    ViewBag.Title = "Adicionar Produto";

#line default
#line hidden
            BeginContext(50, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(57, 13, false);
#line 5 "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\Produtos\AddEdit.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(70, 523, true);
            WriteLiteral(@"</h2>
<form method=""get"">

    <div class=""form-group"">
        <label>Nome</label>
        <input type=""text"" name=""nome"" class=""form-control"" autofocus />
    </div>

    <div class=""form-group"">
        <label>Tipo</label>
        <input type=""text"" name=""tipoprodutoid"" class=""form-control"" />
    </div>

    <div class=""form-group"">
        <label>Valor</label>
        <input type=""text"" name=""valor"" class=""form-control"" />
    </div>

    <button class=""btn btn-secondary"">Salvar</button>
    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 593, "\"", 623, 1);
#line 24 "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\Produtos\AddEdit.cshtml"
WriteAttributeValue("", 600, Url.Action("Produtos"), 600, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(624, 45, true);
            WriteLiteral(" class=\"btn btn-info\">Cancelar</a>\r\n\r\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591