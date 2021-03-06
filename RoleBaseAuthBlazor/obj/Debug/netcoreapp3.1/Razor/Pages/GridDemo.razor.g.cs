#pragma checksum "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\GridDemo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "307bd8e5ffe512566cef03cf2e4c5149241aed55"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/griddemo")]
    public partial class GridDemo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>GridDemo - MatBlazor Grid in Blazor</h3>\r\n");
            __Blazor.RoleBaseAuthBlazor.Pages.GridDemo.TypeInference.CreateMatTable_0(__builder, 1, 2, 
#nullable restore
#line 4 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\GridDemo.razor"
                  prod

#line default
#line hidden
#nullable disable
            , 3, "mat-elevation-z5", 4, (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.AddMarkupContent(6, "<th>Product Id</th>\r\n        ");
                __builder2.AddMarkupContent(7, "<th>Product Name</th>\r\n        ");
                __builder2.AddMarkupContent(8, "<th>Product Qty</th>\r\n        ");
                __builder2.AddMarkupContent(9, "<th>Price</th>\r\n    ");
            }
            , 10, (context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "td");
                __builder2.AddContent(13, 
#nullable restore
#line 12 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\GridDemo.razor"
             context.ProductId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "td");
                __builder2.AddContent(16, 
#nullable restore
#line 13 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\GridDemo.razor"
             context.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenElement(18, "td");
                __builder2.AddContent(19, 
#nullable restore
#line 14 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\GridDemo.razor"
             context.ProductQty

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "td");
                __builder2.AddContent(22, 
#nullable restore
#line 15 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\GridDemo.razor"
             string.Format("${0:f2}", @context.Price)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\kouge\source\repos\Blazor\RoleBaseAuthBlazor\RoleBaseAuthBlazor\Pages\GridDemo.razor"
       
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQty { get; set; }
        public double Price { get; set; }

        public Product(string id, string name, int qty, double price)
        {
            ProductId = id;
            ProductName = name;
            ProductQty = qty;
            Price = price;
        }
    }

    Product[] prod = new Product[]
    {
        new Product("101", "Computer", 2, 800000),
        new Product("102", "Mouse", 1, 600),
        new Product("103", "Laptop", 4, 1500000),
        new Product("104", "Keyboard", 6, 1200),
        new Product("105", "Printer", 3, 10000),
        new Product("106", "Pendrive", 2, 1200),
        new Product("107", "Cable", 8, 800),
        new Product("108", "HardDisk", 3, 240000),
        new Product("109", "Monitor", 2, 20000),
        new Product("110", "Memory Card", 1, 9000)
    };

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.RoleBaseAuthBlazor.Pages.GridDemo
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTable_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTable<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "MatTableHeader", __arg2);
        __builder.AddAttribute(__seq3, "MatTableRow", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
