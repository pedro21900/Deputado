#pragma checksum "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3966a4f9e7de24aa6ea0743463e4e62dd2ca6a7d"
// <auto-generated/>
#pragma warning disable 1591
namespace Teste.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pedro\source\repos\Deputado\Teste\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pedro\source\repos\Deputado\Teste\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pedro\source\repos\Deputado\Teste\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pedro\source\repos\Deputado\Teste\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pedro\source\repos\Deputado\Teste\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pedro\source\repos\Deputado\Teste\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pedro\source\repos\Deputado\Teste\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pedro\source\repos\Deputado\Teste\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pedro\source\repos\Deputado\Teste\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\pedro\source\repos\Deputado\Teste\_Imports.razor"
using Teste.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\pedro\source\repos\Deputado\Teste\_Imports.razor"
using Teste.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\pedro\source\repos\Deputado\Teste\_Imports.razor"
using Teste;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\pedro\source\repos\Deputado\Teste\_Imports.razor"
using Teste.Pages.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/perfil/{id}")]
    public partial class Perfil : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Perfil</h3>");
#nullable restore
#line 5 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
 if (string.IsNullOrWhiteSpace(errorString) == false)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "h2");
            __builder.AddContent(3, 
#nullable restore
#line 7 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                     errorString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
}
else if (deputado is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<div class=\"h4\">Loading...</div>\r\n    <img src=\"/imagens/basicloader.gif\">");
#nullable restore
#line 13 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
}
else
{
       if (appdata.Valorliquido04 == 0 && appdata.Valorliquido03 == 0 && Id != "" && appdata.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "meta");
            __builder.AddAttribute(6, "http-equiv", "refresh");
            __builder.AddAttribute(7, "content", "0;" + " url=\'https://localhost:44392/despesas/" + (
#nullable restore
#line 18 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                                                                       Id

#line default
#line hidden
#nullable disable
            ) + "\'");
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
        appdata.Count++;
    }
    else { }


#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table table-striped");
            __builder.AddMarkupContent(10, "<thead class=\"thead-dark\"><tr><th>Foto</th>\r\n            <th>Descri????o</th></tr></thead>\r\n    ");
            __builder.OpenElement(11, "tbody");
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "th");
            __builder.OpenElement(14, "figure");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", "https://www.camara.leg.br/internet/deputado/bandep/" + (
#nullable restore
#line 34 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                                                                   Id

#line default
#line hidden
#nullable disable
            ) + ".jpg");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "th");
            __builder.OpenElement(19, "table");
            __builder.AddAttribute(20, "class", "table table-striped");
            __builder.OpenElement(21, "thead");
            __builder.OpenElement(22, "tr");
            __builder.OpenElement(23, "th");
            __builder.AddContent(24, "Nome: ");
            __builder.AddContent(25, 
#nullable restore
#line 41 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                       deputado.Dados.NomeCivil

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "th");
            __builder.AddContent(28, "Email: ");
            __builder.AddContent(29, 
#nullable restore
#line 42 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                        deputado.Dados.ultimoStatus.email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "th");
            __builder.AddContent(32, "Escolaridade: ");
            __builder.AddContent(33, 
#nullable restore
#line 43 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                               deputado.Dados.escolaridade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "th");
            __builder.AddContent(36, "Sexo: ");
            __builder.AddContent(37, 
#nullable restore
#line 44 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                       deputado.Dados.sexo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "tbody");
            __builder.OpenElement(40, "tr");
            __builder.OpenElement(41, "th");
            __builder.AddContent(42, "Partido: ");
            __builder.AddContent(43, 
#nullable restore
#line 49 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                          deputado.Dados.ultimoStatus.siglaPartido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.OpenElement(45, "th");
            __builder.AddContent(46, "Nascimento: ");
            __builder.AddContent(47, 
#nullable restore
#line 50 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                             deputado.Dados.dataNascimento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                            ");
            __builder.OpenElement(49, "th");
            __builder.AddMarkupContent(50, "\r\n                                Rede Social:\r\n                                ");
            __builder.OpenElement(51, "ul");
#nullable restore
#line 54 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                     foreach (var rede in @deputado.Dados.redeSocial)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "li");
            __builder.AddContent(53, 
#nullable restore
#line 56 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                             rede

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"

                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.OpenElement(55, "th");
            __builder.AddMarkupContent(56, "<h5>Ultimas despesas</h5>\r\n                                ");
            __builder.OpenElement(57, "table");
            __builder.AddAttribute(58, "class", "table table-striped");
            __builder.OpenElement(59, "thead");
            __builder.AddAttribute(60, "class", "thead-dark");
            __builder.OpenElement(61, "tr");
            __builder.OpenElement(62, "th");
            __builder.AddContent(63, 
#nullable restore
#line 66 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                                  thisDay.Month-1

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(64, "/");
            __builder.AddContent(65, 
#nullable restore
#line 66 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                                                    thisDay.Year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                            ");
            __builder.OpenElement(67, "th");
            __builder.AddContent(68, 
#nullable restore
#line 67 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                                 thisDay.Month

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(69, "/");
            __builder.AddContent(70, 
#nullable restore
#line 67 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                                                thisDay.Year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                                    ");
            __builder.OpenElement(72, "tbody");
            __builder.OpenElement(73, "tr");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 72 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                                 appdata.Valorliquido03.ToString("C")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n                                            ");
            __builder.OpenElement(77, "td");
            __builder.AddContent(78, 
#nullable restore
#line 74 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                                 appdata.Valorliquido04.ToString("C")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.OpenElement(80, "tr");
            __builder.AddMarkupContent(81, "<th></th>\r\n                            <th></th>\r\n                            <th></th>\r\n                            ");
            __builder.OpenElement(82, "th");
            __builder.OpenElement(83, "a");
            __builder.AddAttribute(84, "href", "/");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
                                                       zeravalor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(86, "Voltar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 95 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"

   
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Perfil.razor"
       
    [Parameter]
    public string Id { get; set; }
    Perfildep deputado;
    DespesasDeputado despesas;
    string errorString;
    int currentCount;
    string urlfoto;
    DateTime thisDay = DateTime.Today;
    int Count = 0;
    public void zeravalor()
    {
        appdata.Valorliquido03 = 0;
        appdata.Valorliquido04 = 0;
        Id = "";
        appdata.Count--;
    }
    protected override async Task OnInitializedAsync()
    {

        var request = new HttpRequestMessage(HttpMethod.Get,
    "https://dadosabertos.camara.leg.br/api/v2/deputados/" + Convert.ToInt32(Id));
        var client = _clientFactory.CreateClient();

        HttpResponseMessage response = await client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            deputado = await response.Content.ReadFromJsonAsync<Perfildep>();
            errorString = null;
        }
        else
        {
            errorString = $"erro :{response.ReasonPhrase }";
        }
        if (String.IsNullOrEmpty(deputado.Dados.ultimoStatus.UrlFoto))
        { }
        else
        {
            urlfoto = deputado.Dados.ultimoStatus.UrlFoto;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.AppData appdata { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
    }
}
#pragma warning restore 1591
