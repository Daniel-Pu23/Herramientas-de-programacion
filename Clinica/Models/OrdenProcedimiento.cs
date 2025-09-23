using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Representa un item de tipo procedimiento dentro de una orden medica.
    /// </summary>

    public class OrdenProcedimiento : ItemOrden
    {
        /// <summary>
        /// Procedimiento prescrito.
        /// </summary>
        
        public Procedimiento Procedimiento { get; set; }

        /// <summary>
        /// Número de veces que se debe realizar el procedimiento.
        /// </summary>
        
        public int Repeticiones { get; set; }

        /// <summary>
        /// Frecuencia del procedimiento (Ej: "1 vez por semana").
        /// </summary>
        
        public string Frecuencia { get; set; }

        /// <summary>
        /// Calcula el costo total del procedimiento según repeticiones.
        /// </summary>
        
        public void CalcularCosto()
        {
            Costo = Procedimiento != null
                ? Procedimiento.Costo * Repeticiones
                : 0;
        }

        /// <summary>
        /// Devuelve una descripción breve del procedimiento.
        /// </summary>
        
        public override string Describir()
        {
            return $"{Procedimiento?.Nombre} x{Repeticiones} - {Frecuencia}";
        }
    }
}
