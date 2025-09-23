using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Representa una ayuda diagnostica que puede solicitarse a un paciente.
    /// </summary>
    
    public class AyudaDiagnostica
    {
        /// <summary>
        /// Identificador único de la ayuda diagnóstica.
        /// </summary>
        
        public int Id { get; set; }

        /// <summary>
        /// Nombre del examen o prueba diagnóstica.
        /// </summary>
        
        public string Nombre { get; set; }

        /// <summary>
        /// Costo de la ayuda diagnóstica.
        /// </summary>
        
        public decimal Costo { get; set; }

        /// <summary>
        /// Indica si se requiere asistencia de un especialista para el examen.
        /// </summary>
        
        public bool RequiereEspecialista { get; set; }

        /// <summary>
        /// Tipo de especialidad requerida (solo si aplica).
        /// </summary>
        
        public string TipoEspecialidad { get; set; }

        /// <summary>
        /// Valida si se definió correctamente la especialidad cuando es requerida.
        /// </summary>
        
        public bool EspecialidadValida()
        {
            return !RequiereEspecialista || !string.IsNullOrWhiteSpace(TipoEspecialidad);
        }
    }
}
