#pragma checksum "C:\Users\47651807863\Documents\Exercicios\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8b6147f3afb5ef3d29f2e61c2ac6fc9dc4be907"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Dashboard), @"mvc.1.0.view", @"/Views/Administrador/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Dashboard.cshtml", typeof(AspNetCore.Views_Administrador_Dashboard))]
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
#line 1 "C:\Users\47651807863\Documents\Exercicios\MVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\47651807863\Documents\Exercicios\MVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8b6147f3afb5ef3d29f2e61c2ac6fc9dc4be907", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 275, true);
            WriteLiteral(@"<main>
        <h2>Dashboard</h2>
        <section id=""status-pedidos"">
            <h2>Status dos Agendamentos</h2>
            <div id=""painel"">
                <div class=""box-status-pedidos aprovados"">
                    <h4>Aprovados</h4>
                    <p>");
            EndContext();
            BeginContext(325, 22, false);
#line 9 "C:\Users\47651807863\Documents\Exercicios\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.EventosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(347, 153, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"box-status-pedidos pendentes\">\r\n                    <h4>Pendentes</h4>\r\n                    <p>");
            EndContext();
            BeginContext(501, 22, false);
#line 13 "C:\Users\47651807863\Documents\Exercicios\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.EventosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(523, 155, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"box-status-pedidos reprovados\">\r\n                    <h4>Reprovados</h4>\r\n                    <p>");
            EndContext();
            BeginContext(679, 23, false);
#line 17 "C:\Users\47651807863\Documents\Exercicios\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.EventosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(702, 770, true);
            WriteLiteral(@"</p>
                </div>
            </div>
        </section>

        <section id=""lista-pedidos"">
            <h2>Agendamentos</h2>
            <table>
                <thead>
                    <tr>
                        <th rowspan=""2"">Nome</th>
                        <th rowspan=""2"">Dia(s) do Evento</th>
                        <th rowspan=""2"">Tipo</th>
                        <th rowspan=""2"">Opcional 1</th>
                        <th rowspan=""2"">Opcional 2</th>
                        <th colspan=""2"" rowspan=""2"">Aprovar/Recusar</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <td colspan=""7"">
                            <p>Pedidos atualizados em ");
            EndContext();
            BeginContext(1473, 12, false);
#line 38 "C:\Users\47651807863\Documents\Exercicios\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                                                 Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(1485, 115, true);
            WriteLiteral("</p>\r\n                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 43 "C:\Users\47651807863\Documents\Exercicios\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                     foreach(var evento in Model.Agendamento){

#line default
#line hidden
            BeginContext(1664, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1727, 19, false);
#line 45 "C:\Users\47651807863\Documents\Exercicios\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(evento.cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1746, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1786, 18, false);
#line 46 "C:\Users\47651807863\Documents\Exercicios\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(evento.evento.Data);

#line default
#line hidden
            EndContext();
            BeginContext(1804, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1844, 24, false);
#line 47 "C:\Users\47651807863\Documents\Exercicios\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(evento.evento.TipoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(1868, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1908, 23, false);
#line 48 "C:\Users\47651807863\Documents\Exercicios\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(evento.evento.Opcional1);

#line default
#line hidden
            EndContext();
            BeginContext(1931, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1971, 23, false);
#line 49 "C:\Users\47651807863\Documents\Exercicios\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(evento.evento.Opcional2);

#line default
#line hidden
            EndContext();
            BeginContext(1994, 41, true);
            WriteLiteral("</td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2035, "\'", 2102, 1);
#line 50 "C:\Users\47651807863\Documents\Exercicios\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2042, Url.Action("Aprovar", "Agendamento", new {id = @evento.Id}), 2042, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2103, 74, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2177, "\'", 2245, 1);
#line 51 "C:\Users\47651807863\Documents\Exercicios\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2184, Url.Action("Reprovar", "Agendamento", new {id = @evento.Id}), 2184, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2246, 71, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 53 "C:\Users\47651807863\Documents\Exercicios\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(2340, 81, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </section>\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
