using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Representa un item de tipo medicamento dentro de una orden medica.
    /// </summary>

    public class OrdenMedicamento : ItemOrden
    {
        /// <summary>
        /// Medicamento prescrito.
        /// </summary>
        
        public Medicamento Medicamento { get; set; }

        /// <summary>
        /// Dosis prescrita.
        /// </summary>
        
        public string Dosis { get; set; }

        /// <summary>
        /// Número de días de tratamiento.
        /// </summary>
        
        public int DiasDuracion { get; set; }

        /// <summary>
        /// Calcula automáticamente el costo total basado en duración y costo unitario.
        /// </summary>
        
        public void CalcularCosto()
        {
            Costo = Medicamento != null
                ? Medicamento.PrecioUnidad * DiasDuracion
                : 0;
        }

        /// <summary>
        /// Devuelve una descripción breve del ítem.
        /// </summary>
        
        public override string Describir()
        {
            return $"{Medicamento?.Nombre} - {Dosis} por {DiasDuracion} días";
        }
    }
}
