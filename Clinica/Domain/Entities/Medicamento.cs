using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Representa un medicamento dentro del inventario de la clinica.
    /// </summary>
    
    public class Medicamento
    {
        /// <summary>
        /// Identificador único del medicamento.
        /// </summary>
        
        public int Id { get; set; }

        /// <summary>
        /// Nombre del medicamento.
        /// </summary>
        
        public string Nombre { get; set; }

        /// <summary>
        /// Presentación del medicamento (Ej: Tableta, Inyectable, Jarabe).
        /// </summary>
        
        public string Presentacion { get; set; }

        /// <summary>
        /// Cantidad disponible en el inventario.
        /// </summary>
        
        public int Stock { get; set; }

        /// <summary>
        /// Precio por unidad del medicamento.
        /// </summary>
        
        public decimal PrecioUnidad { get; set; }

        /// <summary>
        /// Verifica si hay suficiente stock para una cantidad requerida.
        /// </summary>
        
        public bool HayStock(int cantidad)
        {
            return cantidad > 0 && Stock >= cantidad;
        }

        /// <summary>
        /// Disminuye el stock actual según una cantidad suministrada.
        /// </summary>
        
        public void DisminuirStock(int cantidad)
        {
            if (HayStock(cantidad))
            {
                Stock -= cantidad;
            }
        }
    }
}
