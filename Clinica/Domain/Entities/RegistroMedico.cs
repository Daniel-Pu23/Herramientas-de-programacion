using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class RegistroMedico
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public Paciente Paciente { get; set; }
        public Usuario Profesional { get; set; }

        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }

        public Orden OrdenMedica { get; set; }
    }
}
