#pragma checksum "/home/brahiam/ProgIII/FinalProject/Pages/RegistroVehiculos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1655d7dda671f66dcf071ee5429f36fedec5acb4"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FinalProject.Pages
{
    #line hidden
    using System.Collections.Generic;
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
#line 2 "/home/brahiam/ProgIII/FinalProject/Pages/RegistroVehiculos.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/brahiam/ProgIII/FinalProject/Pages/RegistroVehiculos.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/brahiam/ProgIII/FinalProject/Pages/RegistroVehiculos.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/brahiam/ProgIII/FinalProject/Pages/RegistroVehiculos.razor"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/registroV")]
    public partial class RegistroVehiculos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "/home/brahiam/ProgIII/FinalProject/Pages/RegistroVehiculos.razor"
 
    string marca;
    string modelo;

    string year;
    string color;
    int seguro;
    float Pdia;
    int tipo;
    float carga;
    int pasajeros;
    double latitud;
    double longitud;
    string Tvehiculo;

    void agregar()
    {
        rentcarContext db = new rentcarContext(rentar);
        TipoVehiculos tipoV = new TipoVehiculos();
        Vehiculos carro = new Vehiculos();
        
        if(tipo == 1){
            Tvehiculo = "carro";
        }if(tipo == 2){
            Tvehiculo = "camioneta";
        }if(tipo == 3){
            Tvehiculo = "motocicleta";
        }if(tipo == 4){
            Tvehiculo = "barco";
        }
        carro.Marca = marca;
        carro.Modelo = modelo;
        carro.Año = year;
        carro.Nroseguro = seguro;
        carro.Precio = Pdia;
        carro.Capacidadcarga = carga;
        carro.Pasajeros = pasajeros;
        tipoV.Tipo = Tvehiculo;
        carro.Latitude = latitud;
        carro.Longitude = longitud;
        db.Add(carro);
        db.SaveChanges();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DbContextOptions<rentcarContext> rentar { get; set; }
    }
}
#pragma warning restore 1591