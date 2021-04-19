using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject.Models
{
    public partial class Alquileres
    {
        public int IdAlquileres { get; set; }
        public int ClientesIdClientes { get; set; }
        public int VehiculosIdVehiculos { get; set; }
        public int VehiculosTipoVehiculosIdTipoVehiculos { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public double Monto { get; set; }

        public virtual Clientes ClientesIdClientesNavigation { get; set; }
        public virtual Vehiculos Vehiculos { get; set; }
    }
}
