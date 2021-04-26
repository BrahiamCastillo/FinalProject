#pragma checksum "/home/brahiam/ProgIII/FinalProject/Pages/PagarFactura.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13c151afee00376b6620fa556242f4d5ab334eb6"
// <auto-generated/>
#pragma warning disable 1591
namespace FinalProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using FinalProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/brahiam/ProgIII/FinalProject/Pages/PagarFactura.razor"
using FinalProject.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pagar")]
    public partial class PagarFactura : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Pagar Factura</h3>\n<hr>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddMarkupContent(7, "<label>Ingrese la ID de la factura:</label>\n        ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "placeholder", "ID Factura");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "/home/brahiam/ProgIII/FinalProject/Pages/PagarFactura.razor"
                       idfactura

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => idfactura = __value, idfactura));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n    ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/home/brahiam/ProgIII/FinalProject/Pages/PagarFactura.razor"
                       Cargar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "class", "btn btn-outline-success");
            __builder.AddContent(18, "Cargar Factura");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n<hr>\n");
#nullable restore
#line 15 "/home/brahiam/ProgIII/FinalProject/Pages/PagarFactura.razor"
 if (activate == false)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "    ");
            __builder.AddMarkupContent(22, "<h3>No se encuentra la factura con dicha ID.</h3>\n");
#nullable restore
#line 19 "/home/brahiam/ProgIII/FinalProject/Pages/PagarFactura.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "    ");
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table table-dark");
            __builder.AddMarkupContent(26, "\n    ");
            __builder.AddMarkupContent(27, "<thead>\n        <tr>\n            <th>ID Factura</th>\n            <th>Monto</th>\n        </tr>\n    </thead>\n    ");
            __builder.OpenElement(28, "tbody");
            __builder.AddMarkupContent(29, "\n        ");
            __builder.OpenElement(30, "tr");
            __builder.AddMarkupContent(31, "\n            ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 31 "/home/brahiam/ProgIII/FinalProject/Pages/PagarFactura.razor"
                 factura.IdAlquileres

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n            ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 32 "/home/brahiam/ProgIII/FinalProject/Pages/PagarFactura.razor"
                 factura.Monto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n    <hr>\n    ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "/home/brahiam/ProgIII/FinalProject/Pages/PagarFactura.razor"
                       Pagar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "class", "btn btn-danger");
            __builder.AddContent(44, "Pagar");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n");
#nullable restore
#line 38 "/home/brahiam/ProgIII/FinalProject/Pages/PagarFactura.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "/home/brahiam/ProgIII/FinalProject/Pages/PagarFactura.razor"
       

    int idfactura;

    rentcarContext context;
    Alquileres factura;

    bool activate = false;
    protected override void OnInitialized()
    {
        context = new rentcarContext(options);
    }



    void Cargar()
    {
        try
        {
            factura = context.Alquileres.Where(f => f.IdAlquileres == idfactura).SingleOrDefault();

            activate = true;
        }
        catch (System.Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    void Pagar()
    {

        factura.Pagado = 1;
        factura.Monto = 0;
        var client = context.Clientes.Where(c => c.IdClientes == factura.ClientesIdClientes).SingleOrDefault();
        string name = client.Nombre + " " + client.Apellido;
        var vehicle = context.Vehiculos.Where(v => v.IdVehiculos == factura.VehiculosIdVehiculos).SingleOrDefault();
        vehicle.Disponible = 1;
        context.SaveChanges();
        string vehicleName = vehicle.Marca + " " + vehicle.Modelo;
        HtmlFormat html = new HtmlFormat();
        html.htmlMake(factura, name, vehicleName, 0, 0);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DbContextOptions<rentcarContext> options { get; set; }
    }
}
#pragma warning restore 1591
