#pragma checksum "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2a235f4a4457cf2041c414bc28fe5b35f22a678"
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
#line 2 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
using FinalProject.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/reserva")]
    public partial class Reservar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Reservación.</h1>\n<hr>\n\n");
#nullable restore
#line 8 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
 if (Vehicles().Count < 1 || Customers().Count < 1)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<h2>No hay vehículos o clientes registrados.</h2>\n");
#nullable restore
#line 12 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group");
            __builder.AddMarkupContent(6, "\n    ");
            __builder.AddMarkupContent(7, "<label for=\"vehiculo\">Selecciones un vehículo.</label>\n    ");
            __builder.OpenElement(8, "select");
            __builder.AddAttribute(9, "name", "vehiculo");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
                    vehiculo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vehiculo = __value, vehiculo));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(12, "\n");
#nullable restore
#line 19 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
         foreach (var veh in Vehicles())
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                ");
            __builder.OpenElement(14, "option");
            __builder.AddAttribute(15, "value", 
#nullable restore
#line 21 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
                                veh.IdVehiculos

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, 
#nullable restore
#line 21 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
                                                  veh.Marca

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " ");
            __builder.AddContent(18, 
#nullable restore
#line 21 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
                                                             veh.Modelo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
#nullable restore
#line 22 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    <hr>\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group");
            __builder.AddMarkupContent(25, "\n    ");
            __builder.AddMarkupContent(26, "<label for=\"customers\">Selecciones un cliente.</label>\n    ");
            __builder.OpenElement(27, "select");
            __builder.AddAttribute(28, "onselect", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 28 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
                        Operation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "name", "vehiculo");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
                                           cliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cliente = __value, cliente));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(32, "\n");
#nullable restore
#line 29 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
         foreach (var cust in Customers())
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "                ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", 
#nullable restore
#line 31 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
                                cust.IdClientes

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(36, 
#nullable restore
#line 31 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
                                                  cust.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(37, " ");
            __builder.AddContent(38, 
#nullable restore
#line 31 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
                                                               cust.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n");
#nullable restore
#line 32 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n    <hr>\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group");
            __builder.AddMarkupContent(45, "\n        ");
            __builder.AddMarkupContent(46, "<label for=\"fecha-inicio\">Selecciona la fecha de inicio.</label>\n        ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "date");
            __builder.AddAttribute(49, "name", "fecha-inicio");
            __builder.AddAttribute(50, "id", "fecha-inicio");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
                             fecha_inicio

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fecha_inicio = __value, fecha_inicio, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n    <hr>\n    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form-group");
            __builder.AddMarkupContent(57, "\n        ");
            __builder.AddMarkupContent(58, "<label for=\"fecha-fin\">Selecciona la fecha del fin de alquiler.</label>\n        ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "type", "date");
            __builder.AddAttribute(61, "name", "fecha-fin");
            __builder.AddAttribute(62, "id", "fecha-fin");
            __builder.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
                             fecha_fin

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fecha_fin = __value, fecha_fin, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n");
            __builder.AddContent(67, "    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "form-group");
            __builder.AddMarkupContent(70, "\n        ");
            __builder.AddMarkupContent(71, "<label for=\"fecha-fin\">Ingrese el monto.</label>\n        ");
            __builder.OpenElement(72, "input");
            __builder.AddAttribute(73, "type", "text");
            __builder.AddAttribute(74, "name", "monto");
            __builder.AddAttribute(75, "id", "monto");
            __builder.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
                             monto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => monto = __value, monto));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\n        ");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
                           Operation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "class", "btn btn-danger");
            __builder.AddContent(82, "Calcular monto");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\n");
            __builder.AddContent(85, "    ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "form-group");
            __builder.AddMarkupContent(88, "\n        ");
            __builder.OpenElement(89, "button");
            __builder.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
                           Process

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "class", "btn btn-dark");
            __builder.AddContent(92, "Alquilar");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\n    <hr>\n    ");
            __builder.OpenElement(95, "h3");
            __builder.AddContent(96, 
#nullable restore
#line 56 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
         message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\n");
#nullable restore
#line 57 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor"
       

    int vehiculo;
    int cliente;
    DateTime fecha_inicio = DateTime.Now;
    DateTime fecha_fin = DateTime.Now.AddDays(10);
    double monto;

    string message = "";

    int timeInDays;

    rentcarContext ctx;

    List<Vehiculos> Vehicles() => new rentcarContext(options).Vehiculos.Where(v => v.Disponible == 1).ToList();

    List<Clientes> Customers() => new rentcarContext(options).Clientes.Where(c => c.Status == 1).ToList();

    protected override void OnInitialized()
    {
        ctx = new rentcarContext(options);
    }

    void Operation()
    {

        try
        {
            timeInDays = (fecha_fin - fecha_inicio).Days;

            var VehicleSelected = ctx.Vehiculos.Where(v => v.IdVehiculos == vehiculo).SingleOrDefault();

            monto = VehicleSelected.Precio * timeInDays;
        }
        catch (System.Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    void Process()
    {

        Alquileres newAlquiler = new Alquileres
        {

            VehiculosIdVehiculos = vehiculo,
            ClientesIdClientes = cliente,
            FechaInicio = fecha_inicio,
            FechaFin = fecha_fin,
            Monto = monto
        };

        try
        {
            ctx.Alquileres.Add(newAlquiler);
            var vehicle = ctx.Vehiculos.Where(i => i.IdVehiculos == vehiculo).SingleOrDefault();
            vehicle.Disponible = 0;
            ctx.SaveChanges();
            var client = ctx.Clientes.Where(c => c.IdClientes == newAlquiler.ClientesIdClientes).SingleOrDefault();
            string Name = client.Nombre + " " + client.Apellido;
            var veh = ctx.Vehiculos.Where(c => c.IdVehiculos == newAlquiler.VehiculosIdVehiculos).SingleOrDefault();
            string auto = veh.Marca + " " + veh.Modelo;
            HtmlFormat fact = new HtmlFormat();
            fact.htmlMake(newAlquiler, Name, auto, timeInDays, monto);
        }
        catch (System.Exception ex)
        {
            Console.WriteLine(ex.Message);
            message = "No se pudo realizar el registro del alquiler";
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DbContextOptions<rentcarContext> options { get; set; }
    }
}
#pragma warning restore 1591