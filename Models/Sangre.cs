using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject.Models
{
    public partial class Sangre
    {
        public Sangre()
        {
            Clientes = new HashSet<Clientes>();
        }

        public int IdSangre { get; set; }
        public string Sangre1 { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}
