using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Visita
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime FechaHora { get; set; } = DateTime.Now;

        public Paciente Paciente { get; set; }
        public Usuario Profesional { get; set; }

        public string MotivoConsulta { get; set; }
        public string Observaciones { get; set; }
    }
}
