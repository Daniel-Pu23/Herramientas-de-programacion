using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Representa una cita agendada entre un paciente y un usuario.
    /// </summary>

    public class Cita
    {
        public Guid Id { get; set; }
        public Paciente Paciente { get; set; }
        public Usuario Profesional { get; set; }
        public DateTime FechaHora { get; set; }
        public string Motivo { get; set; }

        public Cita()
        {
            Id = Guid.NewGuid();
        }
    }
}
