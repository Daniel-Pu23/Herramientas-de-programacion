using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Representa un procedimiento clinico que puede aplicarse a un paciente.
    /// </summary>
    
    public class Procedimiento
    {
        /// <summary>
        /// Identificador único del procedimiento.
        /// </summary>
        
        public int Id { get; set; }

        /// <summary>
        /// Nombre del procedimiento.
        /// </summary>
        
        public string Nombre { get; set; }

        /// <summary>
        /// Costo total del procedimiento.
        /// </summary>
        
        public decimal Costo { get; set; }

        /// <summary>
        /// Indica si el procedimiento requiere asistencia de un especialista.
        /// </summary>
        
        public bool RequiereEspecialista { get; set; }

        /// <summary>
        /// Tipo de especialidad requerida (solo si aplica).
        /// </summary>
        
        public string TipoEspecialidad { get; set; }

        /// <summary>
        /// Verifica si es necesario definir una especialidad.
        /// </summary>
        
        public bool EspecialidadValida()
        {
            return !RequiereEspecialista || !string.IsNullOrWhiteSpace(TipoEspecialidad);
        }
    }
}
