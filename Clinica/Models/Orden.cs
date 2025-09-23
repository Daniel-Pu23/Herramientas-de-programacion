using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Representa una orden medica generada por un medico para un paciente.
    /// </summary>
    
    public class Orden
    {
        /// <summary>
        /// Número único de la orden (hasta 6 dígitos).
        /// </summary>
        
        public int NumeroOrden { get; set; }

        /// <summary>
        /// Cédula del paciente al que se le crea la orden.
        /// </summary>
        
        public string CedulaPaciente { get; set; }

        /// <summary>
        /// Cédula del médico que genera la orden.
        /// </summary>
        
        public string CedulaMedico { get; set; }

        /// <summary>
        /// Fecha de creación de la orden.
        /// </summary>
        
        public DateTime FechaCreacion { get; set; }

        /// <summary>
        /// Lista de ítems asociados a la orden.
        /// </summary>
        
        public List<ItemOrden> Items { get; set; }

        /// <summary>
        /// Constructor que inicializa la lista de ítems y la fecha.
        /// </summary>
        
        public Orden()
        {
            FechaCreacion = DateTime.Now;
            Items = new List<ItemOrden>();
        }

        /// <summary>
        /// Verifica si la orden contiene solo un tipo de ítems.
        /// </summary>
        
        public bool EsOrdenValida()
        {
            if (Items.Count == 0)
                return false;

            var primerTipo = Items[0].GetType();
            foreach (var item in Items)
            {
                if (item.GetType() != primerTipo)
                    return false;
            }

            return true;
        }
    }
}
