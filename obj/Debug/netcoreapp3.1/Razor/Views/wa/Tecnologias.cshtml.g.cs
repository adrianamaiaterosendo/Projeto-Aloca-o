#pragma checksum "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Tecnologias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaa20928fc81a899e5cb9dffec1a092fa72481fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_wa_Tecnologias), @"mvc.1.0.view", @"/Views/wa/Tecnologias.cshtml")]
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
#line 1 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\_ViewImports.cshtml"
using Desafio_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\_ViewImports.cshtml"
using Desafio_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaa20928fc81a899e5cb9dffec1a092fa72481fc", @"/Views/wa/Tecnologias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccba478bb7f14cac52112a4a4373e872b241e336", @"/Views/_ViewImports.cshtml")]
    public class Views_wa_Tecnologias : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Desafio_MVC.Models.Tecnologia>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CadastrarTecnologia", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Wa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Tecnologias.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaa20928fc81a899e5cb9dffec1a092fa72481fc4293", async() => {
                WriteLiteral("Cadastrar Nova Tecnologia");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<hr>
    <h2>Lista de Tecnologias Cadastradas</h2>
    <hr>

    <script>   $(document).ready( function () {
    $('#Tecnologia').DataTable();
} );</script>
    


<table id=""Tecnologia"" class= ""table table-striped table-bordered"">
  <thead>
    <tr>
        <th>Id</th>
        <th>Nome</th>
        <th>Tipo</th>
        <th>Ações</th>
    </tr>
</thead>
<tbody>
");
#nullable restore
#line 29 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Tecnologias.cshtml"
     foreach (var tecnologia in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 32 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Tecnologias.cshtml"
       Write(tecnologia.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n        <td>");
#nullable restore
#line 33 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Tecnologias.cshtml"
       Write(tecnologia.NomeTec);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Tecnologias.cshtml"
       Write(tecnologia.TipoTec);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        \r\n        <td><a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 798, "\"", 840, 2);
            WriteAttributeValue("", 805, "/wa/EditarTecnologia/", 805, 21, true);
#nullable restore
#line 36 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Tecnologias.cshtml"
WriteAttributeValue("", 826, tecnologia.Id, 826, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a> <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", "href=\"", 878, "\"", 918, 2);
            WriteAttributeValue("", 884, "/Tecnologia/Deletar/", 884, 20, true);
#nullable restore
#line 36 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Tecnologias.cshtml"
WriteAttributeValue("", 904, tecnologia.Id, 904, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Deletar</a></td>    \r\n    </tr>\r\n");
#nullable restore
#line 38 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Tecnologias.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n</table><br>\r\n\r\n<a href=\"javascript:history.back();\">Voltar</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Desafio_MVC.Models.Tecnologia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
