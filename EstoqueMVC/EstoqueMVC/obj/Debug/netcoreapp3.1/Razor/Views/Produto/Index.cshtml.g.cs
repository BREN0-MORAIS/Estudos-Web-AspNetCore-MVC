#pragma checksum "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d79130b9406d21f3f74ce7324ad6af2db5c17dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d79130b9406d21f3f74ce7324ad6af2db5c17dd", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c15041f0169a43236112cf9229b84decc8706a51", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<EstoqueMVC.Models.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n        <table class=\"table table-hover\">\r\n\r\n");
            WriteLiteral("            <thead>\r\n");
            WriteLiteral("                <tr>\r\n");
            WriteLiteral("                    <th>ID</th>\r\n                    <th>Nome</th>\r\n                    <th>Quantidade</th>\r\n                    <th>Descrição</th>\r\n                </tr>\r\n            </thead>\r\n");
            WriteLiteral("            <tbody>\r\n\r\n");
#nullable restore
#line 19 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Index.cshtml"
                 foreach (var produto in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 22 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Index.cshtml"
                       Write(produto.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                        <td>
                            <!--cria um link, que chama o controller depois manda pra pagina que deseja,
                            enviando o Id, que coloca o link no nome que esta na tabela
                            --->
");
            WriteLiteral(@"
                            <!---primeiro parametro recebe o texto que vai aparecer,
                            segundo parametro qual aaction que vou enviar, terceiro passa o id para
                            buscar na action
                            segundo---->
                            ");
#nullable restore
#line 34 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Index.cshtml"
                       Write(Html.ActionLink(produto.Nome, "Visualizador", new { id = produto.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <!----<td>");
#nullable restore
#line 36 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Index.cshtml"
                             Write(produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <a href></a></td>-->\r\n                        <td class=\"QTD\"");
            BeginWriteAttribute("id", " id=\"", 1529, "\"", 1556, 3);
            WriteAttributeValue("", 1534, "quantidad(", 1534, 10, true);
#nullable restore
#line 37 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Index.cshtml"
WriteAttributeValue("", 1544, produto.Id, 1544, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1555, ")", 1555, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Index.cshtml"
                                                               Write(produto.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Index.cshtml"
                       Write(produto.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td ><a  class=\"Decremento\" href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1697, "\"", 1731, 3);
            WriteAttributeValue("", 1707, "decrementa(", 1707, 11, true);
#nullable restore
#line 39 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Index.cshtml"
WriteAttributeValue("", 1718, produto.Id, 1718, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1729, ");", 1729, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Decrementa</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 41 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d79130b9406d21f3f74ce7324ad6af2db5c17dd8739", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script type=\"text/javascript\">\r\n\r\n    function decrementa(produtoId) {\r\n         //passa Url Helper que gera, passa a Action do Controller depois o Controler\r\n        var url = \"");
#nullable restore
#line 50 "E:\_Desenvolvimento-Breno_Morais\_Código-Fonte\Estudos-WEB\Estudos-Web-AspNetCore-MVC\EstoqueMVC\EstoqueMVC\Views\Produto\Index.cshtml"
              Write(Url.Action("DecrementarQTD","Produto"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";

        $.post(url, { Id: produtoId }, atualiza);
    }

    function atualiza(reposta) {
        var elemento = $(""#quantidade"" + resposta.Id);
        elemento.html(resposta.Quantidade);
    }


    //ajustar, não esta funcionando a atualização em Tempo real



</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<EstoqueMVC.Models.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
