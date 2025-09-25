using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class SeguroMedico
    {
        public string NombreAseguradora { get; set; }
        public string NumeroPoliza { get; set; }
        public DateTime VigenteHasta { get; set; }
        public bool Activo { get; set; }

        public bool EstaActiva()
        {
            return Activo && VigenteHasta >= DateTime.Today;
        }
    }
}
