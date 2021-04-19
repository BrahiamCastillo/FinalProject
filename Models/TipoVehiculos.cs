using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject.Models
{
    public partial class TipoVehiculos
    {
        public TipoVehiculos()
        {
            Vehiculos = new HashSet<Vehiculos>();
        }

        public int IdTipoVehiculos { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Vehiculos> Vehiculos { get; set; }
    }
}
