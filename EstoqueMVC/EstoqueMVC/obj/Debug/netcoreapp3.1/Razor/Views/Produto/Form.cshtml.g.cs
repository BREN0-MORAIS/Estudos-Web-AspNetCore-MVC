#pragma checksum "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9ae8a9e790991e4fff547d8d3d21c4a36e7508a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Form), @"mvc.1.0.view", @"/Views/Produto/Form.cshtml")]
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
#line 1 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\_ViewImports.cshtml"
using EstoqueMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\_ViewImports.cshtml"
using EstoqueMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ae8a9e790991e4fff547d8d3d21c4a36e7508a", @"/Views/Produto/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c15041f0169a43236112cf9229b84decc8706a51", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Produto/Adiciona"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9ae8a9e790991e4fff547d8d3d21c4a36e7508a4481", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9ae8a9e790991e4fff547d8d3d21c4a36e7508a5540", async() => {
                WriteLiteral("\r\n\r\n    <div>\r\n");
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9ae8a9e790991e4fff547d8d3d21c4a36e7508a5858", async() => {
                    WriteLiteral("\r\n\r\n");
                    WriteLiteral("            ");
#nullable restore
#line 16 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Form.cshtml"
       Write(Html.ValidationMessage("produto.Invalido"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            <label for=\"nome\">Nome</label> <br>\r\n\r\n");
                    WriteLiteral("            <input id=\"nome\" name=\"produto.Nome\" />\r\n");
                    WriteLiteral("            ");
#nullable restore
#line 25 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Form.cshtml"
       Write(Html.ValidationMessage("produto.Nome"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            <br>\r\n            <label for=\"preco\">Preço:</label> <br>  <!----Value preenche com o valor do retorno caso alguma validação der erro-->\r\n            <input id=\"preco\" name=\"produto.Preco\"");
                    BeginWriteAttribute("value", " value=\"", 1162, "\"", 1191, 1);
#nullable restore
#line 28 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Form.cshtml"
WriteAttributeValue("", 1170, ViewBag.Produto.Nome, 1170, 21, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n            <br>\r\n            <label for=\"quantidade\">Quantidade:</label> <br>\r\n            <input id=\"quantidade\" name=\"produto.Quantidade\"");
                    BeginWriteAttribute("value", " value=\"", 1337, "\"", 1372, 1);
#nullable restore
#line 31 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Form.cshtml"
WriteAttributeValue("", 1345, ViewBag.Produto.Quantidade, 1345, 27, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n            <br>\r\n            <label for=\"descricao\">Descrição:</label> <br>\r\n            <input id=\"descricao\" name=\"produto.Descricao\"");
                    BeginWriteAttribute("value", " value=\"", 1514, "\"", 1548, 1);
#nullable restore
#line 34 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Form.cshtml"
WriteAttributeValue("", 1522, ViewBag.Produto.Descricao, 1522, 26, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n            <br>\r\n            <label for=\"categoria\">Categoria:</label> <br>\r\n\r\n");
                    WriteLiteral("            <select id=\"categoria\" name=\"produto.CategoriaId\">\r\n");
#nullable restore
#line 44 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Form.cshtml"
                 foreach (var categoria in ViewBag.Categorias)
                {


#line default
#line hidden
#nullable disable
                    WriteLiteral("                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9ae8a9e790991e4fff547d8d3d21c4a36e7508a9464", async() => {
#nullable restore
#line 47 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Form.cshtml"
                                                                                                          Write(categoria.Nome);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Form.cshtml"
                       WriteLiteral(categoria.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Form.cshtml"
AddHtmlAttributeValue("", 2099, categoria.Id.Equals(ViewBag.Produto.CategoriaId), 2099, 49, false);

#line default
#line hidden
#nullable disable
                    EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 48 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Form.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("            </select> <br> <br>\r\n\r\n");
                    WriteLiteral("            <input class=\"btn-border-wine\" type=\"submit\" value=\"Cadastrar\" />\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
