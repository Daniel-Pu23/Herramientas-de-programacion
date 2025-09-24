using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Representa un item de tipo ayuda diagnostica dentro de una orden medica.
    /// </summary>

    public class OrdenAyudasD : ItemOrden
    {
        /// <summary>
        /// Ayuda diagnostica solicitada.
        /// </summary>
        
        public AyudaDiagnostica Ayuda { get; set; }

        /// <summary>
        /// Cantidad. (ej: cuantas veces se realiza un examen)
        /// </summary>
        
        public int Cantidad { get; set; }

        /// <summary>
        /// Calcula el costo total segun la cantidad.
        /// </summary>
        
        public void CalcularCosto()
        {
            Costo = Ayuda != null
                ? Ayuda.Costo * Cantidad
                : 0;
        }

        /// <summary>
        /// Devuelve una descripcion legible del examen.
        /// </summary>
        
        public override string Describir()
        {
            return $"{Ayuda?.Nombre} x{Cantidad}";
        }
    }
}
