#pragma checksum "C:\Users\040161\Desktop\git\Renato0712\PROJETO01\Views\Cidade\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fe98cf64d476bece1d04c98529a270ee1e60869"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cidade_Listar), @"mvc.1.0.view", @"/Views/Cidade/Listar.cshtml")]
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
#line 1 "C:\Users\040161\Desktop\git\Renato0712\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\040161\Desktop\git\Renato0712\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fe98cf64d476bece1d04c98529a270ee1e60869", @"/Views/Cidade/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a24eea2b15d20d16798ed9e4b0c9c93903b076", @"/Views/_ViewImports.cshtml")]
    public class Views_Cidade_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PROJETO01.Modelos.Cidade>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h3>
    CADASTRO DE CIDADES
    <a class=""btn btn-sm btn-primary float-right"" href=""/Cidade/Adicionar"">
        + ADICIONAR
    </a>
</h3>

<table class=""table table-hover "">
    <thead>
        <tr>
            <th>CidadeId</th>
            <th>Nome</th>
            <th>UF</th>
            <th>Ações</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\040161\Desktop\git\Renato0712\PROJETO01\Views\Cidade\Listar.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\040161\Desktop\git\Renato0712\PROJETO01\Views\Cidade\Listar.cshtml"
           Write(item.CidadeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\040161\Desktop\git\Renato0712\PROJETO01\Views\Cidade\Listar.cshtml"
           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\040161\Desktop\git\Renato0712\PROJETO01\Views\Cidade\Listar.cshtml"
           Write(item.UF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           \r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 618, "\"", 663, 2);
            WriteAttributeValue("", 625, "/Cidade/Editar?CidadeId=", 625, 24, true);
#nullable restore
#line 28 "C:\Users\040161\Desktop\git\Renato0712\PROJETO01\Views\Cidade\Listar.cshtml"
WriteAttributeValue("", 649, item.CidadeID, 649, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-warning\">\r\n                    Editar\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 766, "\"", 812, 2);
            WriteAttributeValue("", 773, "/Cidade/Excluir?CidadeId=", 773, 25, true);
#nullable restore
#line 31 "C:\Users\040161\Desktop\git\Renato0712\PROJETO01\Views\Cidade\Listar.cshtml"
WriteAttributeValue("", 798, item.CidadeID, 798, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\">\r\n                    Excluir\r\n                </a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\040161\Desktop\git\Renato0712\PROJETO01\Views\Cidade\Listar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PROJETO01.Modelos.Cidade>> Html { get; private set; }
    }
}
#pragma warning restore 1591
