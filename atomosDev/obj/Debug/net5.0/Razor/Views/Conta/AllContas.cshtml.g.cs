#pragma checksum "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\AllContas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ee3ed84cc1842317c79960fb43b455eda3c5998"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conta_AllContas), @"mvc.1.0.view", @"/Views/Conta/AllContas.cshtml")]
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
#line 1 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\_ViewImports.cshtml"
using atomosDev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\AllContas.cshtml"
using atomosDev.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee3ed84cc1842317c79960fb43b455eda3c5998", @"/Views/Conta/AllContas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c69b5d0fbf5df5659160f2aa2f70b40ab5e2025e", @"/Views/_ViewImports.cshtml")]
    public class Views_Conta_AllContas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3 class=\"display-5\">Consulte as contas</h3>\r\n<hr>\r\n");
#nullable restore
#line 6 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\AllContas.cshtml"
 foreach (Cliente clientes in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 class=\"display-5\">Titular da Conta: ");
#nullable restore
#line 8 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\AllContas.cshtml"
                                       Write(clientes.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
    <table class=""table table-striped table-hover"">
        <thead>
        <th scope=""col"">Id</th>
        <th scope=""col"">Tipo de Conta</th>
        <th scope=""col"">Agencia</th>
        <th scope=""col"">Conta</th>
        <th scope=""col"">Saldo</th>
    </thead>
    <tbody>
");
#nullable restore
#line 18 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\AllContas.cshtml"
         foreach (Conta contas in clientes.contas)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\AllContas.cshtml"
               Write(contas.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 23 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\AllContas.cshtml"
                     switch(contas.tipo)
                    {
                        case 0: 

#line default
#line hidden
#nullable disable
            WriteLiteral("Conta Corrente");
#nullable restore
#line 25 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\AllContas.cshtml"
                                                           ; break;
                        case 1: 

#line default
#line hidden
#nullable disable
            WriteLiteral("Conta Poupança");
#nullable restore
#line 26 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\AllContas.cshtml"
                                                           ; break;
                        case 2: 

#line default
#line hidden
#nullable disable
            WriteLiteral("Conta Investimento");
#nullable restore
#line 27 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\AllContas.cshtml"
                                                               ; break;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>");
#nullable restore
#line 30 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\AllContas.cshtml"
               Write(contas.agencia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\AllContas.cshtml"
               Write(contas.conta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>R$ ");
#nullable restore
#line 32 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\AllContas.cshtml"
                  Write(contas.saldo.ToString("n"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\AllContas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    </table>\r\n");
#nullable restore
#line 37 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\AllContas.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
