#pragma checksum "/home/brahiam/ProgIII/FinalProject/Pages/Reservar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2a235f4a4457cf2041c414bc28fe5b35f22a678"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
