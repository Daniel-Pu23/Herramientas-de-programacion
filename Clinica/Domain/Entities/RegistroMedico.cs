using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Representa un registro medico asociado a un paciente.
    /// </summary>

    public class RegistroMedico
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Paciente al que se le registra la historia.
        /// </summary>
        
        public Paciente Paciente { get; set; }

        /// <summary>
        /// Médico responsable del registro.
        /// </summary>
        
        public Usuario Medico { get; set; }

        /// <summary>
        /// Fecha del registro médico.
        /// </summary>
        
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Motivo de la consulta.
        /// </summary>
        
        public string MotivoConsulta { get; set; }

        /// <summary>
        /// Diagnóstico emitido.
        /// </summary>
        
        public string Diagnostico { get; set; }

        /// <summary>
        /// Lista de órdenes emitidas en esta atención.
        /// </summary>
        
        public List<Orden> Ordenes { get; set; }

        public RegistroMedico()
        {
            Id = Guid.NewGuid();
            Fecha = DateTime.Now;
            Ordenes = new List<Orden>();
        }
    }
}
