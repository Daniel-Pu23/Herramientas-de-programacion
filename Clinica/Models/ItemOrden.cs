using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Clase base abstracta para los items de una orden medica.
    /// </summary>

    public class ItemOrden
    {
        /// <summary>
        /// Número de orden al que pertenece este ítem.
        /// </summary>
        
        public int NumeroOrden { get; set; }

        /// <summary>
        /// Número único del ítem dentro de la orden (comienza desde 1).
        /// </summary>
        
        public int NumeroItem { get; set; }

        /// <summary>
        /// Costo total de este ítem.
        /// </summary>
        
        public decimal Costo { get; set; }

        /// <summary>
        /// Método abstracto para obtener una descripción textual del ítem.
        /// </summary>
        
        public abstract string Describir();
    }
}
