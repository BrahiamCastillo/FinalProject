#pragma checksum "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2891d6d6231216b0f48f11aadfd665a674bde4f6"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editarV")]
    public partial class EditarVehiculo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar Vehiculos</h3>\n<hr>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddMarkupContent(7, "<label>Ingrese el numero de seguro del vehiculo:</label>\n        ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "placeholder", "Numero de seguro");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                                                                          seguro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => seguro = __value, seguro));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n    ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                       Cargar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "class", "btn btn-outline-success");
            __builder.AddContent(18, "Cargar Cehiculos");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n<hr>\n");
#nullable restore
#line 18 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
 if (activated == true && enable == true)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "container");
            __builder.AddMarkupContent(24, "\n    ");
            __builder.OpenElement(25, "form");
            __builder.AddAttribute(26, "class", "form");
            __builder.AddMarkupContent(27, "\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group");
            __builder.AddMarkupContent(30, "\n            ");
            __builder.AddMarkupContent(31, "<label>Marca</label>\n            ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddAttribute(34, "placeholder", "Marca");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                                                                    marca

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => marca = __value, marca));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group");
            __builder.AddMarkupContent(41, "\n            ");
            __builder.AddMarkupContent(42, "<label>Modelo</label>\n            ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "class", "form-control");
            __builder.AddAttribute(45, "placeholder", "Modelo");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                                                                    modelo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => modelo = __value, modelo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n\n        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group");
            __builder.AddMarkupContent(52, "\n            ");
            __builder.AddMarkupContent(53, "<label>Año</label>\n            ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "class", "form-control");
            __builder.AddAttribute(56, "placeholder", "Año");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                                                                 year

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => year = __value, year));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n\n        ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "form-group");
            __builder.AddMarkupContent(63, "\n            ");
            __builder.AddMarkupContent(64, "<label>Color</label>\n            ");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "class", "form-control");
            __builder.AddAttribute(67, "placeholder", "Color");
            __builder.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                                                                   color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => color = __value, color));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\n\n        ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "form-group");
            __builder.AddMarkupContent(74, "\n            ");
            __builder.AddMarkupContent(75, "<label>Precio por dia</label>\n            ");
            __builder.OpenElement(76, "input");
            __builder.AddAttribute(77, "class", "form-control");
            __builder.AddAttribute(78, "placeholder", "Precio por dia ");
            __builder.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                                                                             Pdia

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Pdia = __value, Pdia));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n\n        ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "form-group");
            __builder.AddMarkupContent(85, "\n            ");
            __builder.AddMarkupContent(86, "<label>Tipo de vehiculo</label>\n            ");
            __builder.OpenElement(87, "select");
            __builder.AddAttribute(88, "class", "form-control");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                                                tipo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tipo = __value, tipo));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(91, "\n");
#nullable restore
#line 51 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                 foreach (var tpv in VehiclesTypes())
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "                    ");
            __builder.OpenElement(93, "option");
            __builder.AddAttribute(94, "value", 
#nullable restore
#line 53 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                                    tpv.IdTipoVehiculos

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(95, 
#nullable restore
#line 53 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                                                          tpv.Tipo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n");
#nullable restore
#line 54 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\n\n         ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "form-group");
            __builder.AddMarkupContent(102, "\n            ");
            __builder.AddMarkupContent(103, "<label>Capacidad de carga</label>\n            ");
            __builder.OpenElement(104, "input");
            __builder.AddAttribute(105, "class", "form-control");
            __builder.AddAttribute(106, "placeholder", "Capacidad de carga en kg");
            __builder.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                                                                                      carga

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => carga = __value, carga));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\n\n        ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "form-group");
            __builder.AddMarkupContent(113, "\n            ");
            __builder.AddMarkupContent(114, "<label>Pasajeros</label>\n            ");
            __builder.OpenElement(115, "input");
            __builder.AddAttribute(116, "class", "form-control");
            __builder.AddAttribute(117, "placeholder", "pasajeros");
            __builder.AddAttribute(118, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                                                                       pasajeros

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(119, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pasajeros = __value, pasajeros));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\n        <hr>\n        ");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "form-group");
            __builder.AddMarkupContent(124, "\n            ");
            __builder.AddMarkupContent(125, "<label>Latitud</label>\n            ");
            __builder.OpenElement(126, "input");
            __builder.AddAttribute(127, "class", "form-control");
            __builder.AddAttribute(128, "placeholder", "Latitud");
            __builder.AddAttribute(129, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                                                                     latitud

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(130, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => latitud = __value, latitud));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\n\n        ");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "form-group");
            __builder.AddMarkupContent(135, "\n            ");
            __builder.AddMarkupContent(136, "<label>Longitud</label>\n            ");
            __builder.OpenElement(137, "input");
            __builder.AddAttribute(138, "class", "form-control");
            __builder.AddAttribute(139, "placeholder", "Longitud");
            __builder.AddAttribute(140, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                                                                      longitud

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(141, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => longitud = __value, longitud));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\n\n        ");
            __builder.OpenElement(144, "button");
            __builder.AddAttribute(145, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
                           Editar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(146, "class", "btn btn-outline-success");
            __builder.AddContent(147, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\n    <hr>\n    ");
            __builder.OpenElement(151, "h3");
            __builder.AddContent(152, 
#nullable restore
#line 82 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
         notification

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\n");
#nullable restore
#line 83 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
}    

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "/home/brahiam/ProgIII/FinalProject/Pages/EditarVehiculo.razor"
 
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

    string notification = "";
    bool enable = true;
    bool activated = false;
    Vehiculos vehiculo = null;
    rentcarContext db;

    

    protected override void OnInitialized()
    {
        db = new rentcarContext(rentar);
    }

    List<TipoVehiculos> VehiclesTypes() => db.TipoVehiculos.ToList();
    
    void Cargar()
    {
        vehiculo = db.Vehiculos.Where(C => C.Nroseguro == seguro).SingleOrDefault();

         

        if(vehiculo == null)
        {
            enable = false;
        }
        else
        {
            marca = vehiculo.Marca;
            modelo = vehiculo.Modelo;
            year = vehiculo.Año;
            color = vehiculo.Color;
            Pdia = vehiculo.Precio;
            tipo = vehiculo.TipoVehiculosIdTipoVehiculos;
            carga = vehiculo.Capacidadcarga;
            pasajeros = vehiculo.Pasajeros;
            latitud = vehiculo.Latitude;
            longitud = vehiculo.Longitude;

            
        }
        activated = true;
    }
    void Editar()
    {
        try
        {
            vehiculo.Nroseguro = seguro;
            vehiculo.Año = year;
            vehiculo.Capacidadcarga = carga;
            vehiculo.Color = color;
            vehiculo.Latitude = latitud;
            vehiculo.Longitude = longitud;
            vehiculo.Marca = marca;
            vehiculo.Pasajeros = pasajeros;
            vehiculo.Precio = Pdia;
            vehiculo.TipoVehiculosIdTipoVehiculos = tipo;

            db.SaveChanges();
        }
        catch(System.Exception ex)
        {
            Console.WriteLine(ex.Message);
            notification = "La edicion no de pudo realizar";        
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DbContextOptions<rentcarContext> rentar { get; set; }
    }
}
#pragma warning restore 1591