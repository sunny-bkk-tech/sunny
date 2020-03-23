#pragma checksum "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb42952631fc0a548eb6e468c7fb5afd8956f0cd"
// <auto-generated/>
#pragma warning disable 1591
namespace KPSL.Collacteral.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using KPSL.Collacteral.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using KPSL.Collacteral.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor"
using KPSL.Collacteral.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor"
using Csla.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor"
using Csla.Rules;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>\r\n\r\n");
            __builder.OpenElement(2, "p");
            __builder.AddMarkupContent(3, "\r\n ");
            __builder.OpenElement(4, "div");
            __builder.AddContent(5, "what: ");
            __builder.AddContent(6, 
#nullable restore
#line 14 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor"
             Csla.ApplicationContext.User

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n  ");
            __builder.OpenElement(8, "div");
            __builder.AddContent(9, "Username: ");
            __builder.AddContent(10, 
#nullable restore
#line 15 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor"
                  Csla.ApplicationContext.User.Identity.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n  ");
            __builder.OpenElement(12, "div");
            __builder.AddContent(13, "IsAuthenticated: ");
            __builder.AddContent(14, 
#nullable restore
#line 16 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor"
                         Csla.ApplicationContext.User.Identity.IsAuthenticated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 18 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "    ");
            __builder.AddMarkupContent(18, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 21 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "     ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "content px-4");
            __builder.AddMarkupContent(22, " \r\n  ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(23);
            __builder.AddAttribute(24, "Roles", "admin");
            __builder.AddAttribute(25, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(26, " \r\n\r\n\r\n ");
                __builder2.OpenElement(27, "table");
                __builder2.AddAttribute(28, "class", "table");
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.AddMarkupContent(30, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
                __builder2.OpenElement(31, "tbody");
                __builder2.AddMarkupContent(32, "\r\n");
#nullable restore
#line 39 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(33, "                ");
                __builder2.OpenElement(34, "tr");
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __builder2.OpenElement(36, "td");
                __builder2.AddContent(37, 
#nullable restore
#line 42 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.OpenElement(39, "td");
                __builder2.AddContent(40, 
#nullable restore
#line 43 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                    ");
                __builder2.OpenElement(42, "td");
                __builder2.AddContent(43, 
#nullable restore
#line 44 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                    ");
                __builder2.OpenElement(45, "td");
                __builder2.AddContent(46, 
#nullable restore
#line 45 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n");
#nullable restore
#line 47 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(49, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n    You are Admin Yeah !\r\n    ");
            }
            ));
            __builder.AddAttribute(52, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(53, "\r\n        Hey, this isn\'t for you!\r\n     ");
            }
            ));
            __builder.AddAttribute(54, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(55, "\r\n            Authorizing... \r\n         ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 61 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor"

   
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
