using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject.Models
{
    public partial class Vehiculos
    {
        public Vehiculos()
        {
            Alquileres = new HashSet<Alquileres>();
        }

        public int IdVehiculos { get; set; }
        public int TipoVehiculosIdTipoVehiculos { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public string Color { get; set; }
        public float Precio { get; set; }
        public float Capacidadcarga { get; set; }
        public int Pasajeros { get; set; }
        public int Nroseguro { get; set; }
        public string Foto { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public sbyte Disponible { get; set; }
        public sbyte Status { get; set; }

        public virtual TipoVehiculos TipoVehiculosIdTipoVehiculosNavigation { get; set; }
        public virtual ICollection<Alquileres> Alquileres { get; set; }
    }
}
