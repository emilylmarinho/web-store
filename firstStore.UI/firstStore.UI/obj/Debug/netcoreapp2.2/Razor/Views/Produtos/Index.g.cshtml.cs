#pragma checksum "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\Produtos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa65f2d78bcccd9b038f7eef4f22cfad1cb7a234"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Index), @"mvc.1.0.view", @"/Views/Produtos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produtos/Index.cshtml", typeof(AspNetCore.Views_Produtos_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa65f2d78bcccd9b038f7eef4f22cfad1cb7a234", @"/Views/Produtos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4087f6a12f81513f104d5d9406be3c9657e1fff2", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\Produtos\Index.cshtml"
  
    ViewBag.Title = "Listagem de Produtos";

#line default
#line hidden
            BeginContext(81, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(86, 13, false);
#line 5 "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\Produtos\Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(99, 46, true);
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 145, "\"", 174, 1);
#line 8 "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\Produtos\Index.cshtml"
WriteAttributeValue("", 152, Url.Action("AddEdit"), 152, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(175, 235, true);
            WriteLiteral(">Adicionar</a>\r\n</div>\r\n\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>Nome</th>\r\n            <th>Tipo</th>\r\n            <th>Valor</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 21 "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\Produtos\Index.cshtml"
      foreach (var item in Model)
     {

#line default
#line hidden
            BeginContext(453, 35, true);
            WriteLiteral("        <div><tr>\r\n            <td>");
            EndContext();
            BeginContext(489, 9, false);
#line 24 "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\Produtos\Index.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(498, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(522, 14, false);
#line 25 "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\Produtos\Index.cshtml"
           Write(item.Tipo.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(536, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(560, 10, false);
#line 26 "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\Produtos\Index.cshtml"
           Write(item.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(570, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(611, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa65f2d78bcccd9b038f7eef4f22cfad1cb7a2346402", async() => {
                BeginContext(690, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\Produtos\Index.cshtml"
                                                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(700, 24, true);
            WriteLiteral("\r\n                <buton");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 724, "\"", 767, 6);
            WriteAttributeValue("", 734, "excluir(\'", 734, 9, true);
#line 29 "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\Produtos\Index.cshtml"
WriteAttributeValue("", 743, item.Id, 743, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 751, "\',", 751, 2, true);
            WriteAttributeValue(" ", 753, "\'", 754, 2, true);
#line 29 "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\Produtos\Index.cshtml"
WriteAttributeValue("", 755, item.Nome, 755, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 765, "\')", 765, 2, true);
            EndWriteAttribute();
            BeginContext(768, 90, true);
            WriteLiteral(" class=\"btn btn-danger btn-sm\">Excluir</buton>\r\n            </td>\r\n\r\n        </tr></div>\r\n");
            EndContext();
#line 33 "C:\Users\evyma\Documents\web-store\firstStore.UI\firstStore.UI\Views\Produtos\Index.cshtml"
     }

#line default
#line hidden
            BeginContext(866, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(909, 142, true);
                WriteLiteral(" \r\n    <script>\r\n\r\n        function excluir(id, nome)\r\n        {\r\n            alert(\"excluindo \" + id + nome);\r\n\r\n        }\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(1054, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
