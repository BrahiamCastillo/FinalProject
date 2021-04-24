using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject.Models
{
    public partial class Clientes
    {
        public Clientes()
        {
            Alquileres = new HashSet<Alquileres>();
        }

        public int IdClientes { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Licencia { get; set; }
        public string Nacionalidad { get; set; }
        public string Tipodesangre { get; set; }
        public string Fotopersona { get; set; }
        public string Fotolicencia { get; set; }
        public sbyte Status { get; set; }

        public virtual ICollection<Alquileres> Alquileres { get; set; }
    }
}
