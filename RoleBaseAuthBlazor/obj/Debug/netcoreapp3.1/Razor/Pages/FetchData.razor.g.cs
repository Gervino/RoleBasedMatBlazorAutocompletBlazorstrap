#pragma checksum "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "816fe4a671ad5400bf47151224c83a5861cdc245"
// <auto-generated/>
#pragma warning disable 1591
namespace RoleBaseAuthBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\_Imports.razor"
using RoleBaseAuthBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\_Imports.razor"
using RoleBaseAuthBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\FetchData.razor"
using RoleBaseAuthBlazor.Data;

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
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenComponent<BlazorStrap.BSTable>(5);
            __builder.AddAttribute(6, "IsBordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\FetchData.razor"
                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "IsStriped", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\FetchData.razor"
                                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "IsDark", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\FetchData.razor"
                                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<BlazorStrap.BSTableHead>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n            ");
                    __builder3.AddMarkupContent(14, "<tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenComponent<BlazorStrap.BSTableBody>(16);
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(18, "\r\n");
#nullable restore
#line 26 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(19, "                ");
                    __builder3.OpenElement(20, "tr");
                    __builder3.AddMarkupContent(21, "\r\n                    ");
                    __builder3.OpenElement(22, "td");
                    __builder3.AddContent(23, 
#nullable restore
#line 29 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(24, "\r\n                    ");
                    __builder3.OpenElement(25, "td");
                    __builder3.AddContent(26, 
#nullable restore
#line 30 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(27, "\r\n                    ");
                    __builder3.OpenElement(28, "td");
                    __builder3.AddContent(29, 
#nullable restore
#line 31 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(30, "\r\n                    ");
                    __builder3.OpenElement(31, "td");
                    __builder3.AddContent(32, 
#nullable restore
#line 32 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(33, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\r\n");
#nullable restore
#line 34 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(35, "        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 57 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\FetchData.razor"
              
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
