#pragma checksum "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6570c57e62dc22f14109c043aa0110609faa6df1"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ListaDeputados</h3>");
#nullable restore
#line 6 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
 if (string.IsNullOrWhiteSpace(errorString) == false)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "h2");
            __builder.AddContent(3, 
#nullable restore
#line 8 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                     errorString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
}
else if (deputado is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<div class=\"h4\">Loading...</div>\r\n    <img src=\"/imagens/basicloader.gif\">");
#nullable restore
#line 14 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p></p>\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-6");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "input-group h2");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "name", "data[search]");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "placeholder", "Pesquisar Deputados");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                          inputValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => inputValue = __value, inputValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-primary");
            __builder.AddAttribute(20, "type", "submit");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                                                                    OnInitializedAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "<span class=\"glyphicon glyphicon-search\">Pesquisar</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table table-striped");
            __builder.AddMarkupContent(26, "<thead class=\"thead-dark\"><tr><th>Nome</th>\r\n                <th>Partido</th>\r\n                <th>UF</th>\r\n                <th>Email</th>\r\n                <th>Detalhes</th></tr></thead>\r\n        ");
            __builder.OpenElement(27, "tbody");
#nullable restore
#line 37 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
             if (xx > deputado.Dados.Count() / 5&& deputado.Dados.Count()>5)
            {

            }
            else
            {

                var ini = 0 + (xx - 1) * 5;
                var pagina = 4 + (xx - 1) * 5;
                var lolo = deputado.Dados.Count();
                if (deputado.Dados.Count() < 5)
                {
                    pagina = deputado.Dados.Count() - 1;
                }
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                 for (var d = ini; d <= pagina; d++)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "tr");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 54 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                             deputado.Dados[d].Nome

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 55 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                             deputado.Dados[d].SiglaPartido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 56 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                             deputado.Dados[d].SiglaUf

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 57 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                             deputado.Dados[d].Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "td");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "href", "/perfil/" + (
#nullable restore
#line 59 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                                              deputado.Dados[d].Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                                                                              IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "Vizualizar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                    
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                 }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.OpenElement(48, "nav");
            __builder.AddAttribute(49, "aria-label", "Navega????o de p??gina exemplo");
            __builder.OpenElement(50, "ul");
            __builder.AddAttribute(51, "class", "pagination");
            __builder.OpenElement(52, "li");
            __builder.AddAttribute(53, "class", "page-item");
            __builder.OpenElement(54, "a");
            __builder.AddAttribute(55, "class", "page-link");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                                                                 DownHeading

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, "Anterior");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.OpenElement(59, "li");
            __builder.AddAttribute(60, "class", "page-item");
            __builder.OpenElement(61, "a");
            __builder.AddAttribute(62, "class", "page-link");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                                                                 Update1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(64, 
#nullable restore
#line 69 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                                                                            (5 * x) - 4

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.OpenElement(66, "li");
            __builder.AddAttribute(67, "class", "page-item");
            __builder.OpenElement(68, "a");
            __builder.AddAttribute(69, "class", "page-link");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                                                                 Update2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(71, 
#nullable restore
#line 70 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                                                                            (5 * x) - 4+1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.OpenElement(73, "li");
            __builder.AddAttribute(74, "class", "page-item");
            __builder.OpenElement(75, "a");
            __builder.AddAttribute(76, "class", "page-link");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                                                                 Update3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, 
#nullable restore
#line 71 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                                                                            (5 * x) - 4+2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.OpenElement(80, "li");
            __builder.AddAttribute(81, "class", "page-item");
            __builder.OpenElement(82, "a");
            __builder.AddAttribute(83, "class", "page-link");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                                                                 Update4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(85, 
#nullable restore
#line 72 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                                                                            (5 * x) - 4+3

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n            ");
            __builder.OpenElement(87, "li");
            __builder.AddAttribute(88, "class", "page-item");
            __builder.OpenElement(89, "a");
            __builder.AddAttribute(90, "class", "page-link");
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                                                                 Update5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(92, 
#nullable restore
#line 73 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                                                                            5 * x

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.OpenElement(94, "li");
            __builder.AddAttribute(95, "class", "page-item");
            __builder.OpenElement(96, "a");
            __builder.AddAttribute(97, "class", "page-link");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
                                                                 UpdateHeading

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(99, "Pr??ximo");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 77 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\pedro\source\repos\Deputado\Teste\Pages\Index.razor"
       
    string inputValue;
    PerfilDeputado deputado;
    string errorString;
    int x;
    int xx;
    private void UpdateHeading()
    {
        if (x == (deputado.Dados.Count() / 5)) { }
        else
        {
            x++;
            xx = (5 * x) - 4;
        }
    }
    private void DownHeading()
    {
        if (x == 1) { }
        else
        {
            x--;
            xx = (5 * x);

        }
    }
    private void Update1()
    {
        xx = ((5 * x) - 4);
    }
    private void Update2()
    {
        xx = ((5 * x) - 4 + 1);
    }
    private void Update3()
    {
        xx = ((5 * x) - 4 + 2);
    }
    private void Update4()
    {
        xx = ((5 * x) - 4 + 3);
    }
    private void Update5()
    {
        xx = ((5 * x));
    }
    private void IncrementCount()
    {
        appdata.currentCount++;
    }

    protected override async Task OnInitializedAsync()
    {

        x = 1;
        xx = 1;

        var request = new HttpRequestMessage(HttpMethod.Get,
    "https://dadosabertos.camara.leg.br/api/v2/deputados?nome=" + inputValue + "&ordem=ASC&ordenarPor=nome");

        var client = _clientFactory.CreateClient();

        HttpResponseMessage response = await client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {

            deputado = await response.Content.ReadFromJsonAsync<PerfilDeputado>();
            errorString = null;
        }
        else
        {
            errorString = $"erro :{response.ReasonPhrase }";
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
