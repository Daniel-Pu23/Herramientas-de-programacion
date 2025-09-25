using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Representa una factura generada para un paciente.
    /// </summary>

    public class Facturacion
    {
        public int Id { get; set; }

        /// <summary>
        /// Paciente al que se le emite la factura.
        /// </summary>
        
        public Paciente Paciente { get; set; }

        /// <summary>
        /// Médico que generó la atención facturada.
        /// </summary>
        
        public Usuario Medico { get; set; }

        /// <summary>
        /// Fecha de emisión de la factura.
        /// </summary>
        
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Diagnóstico emitido en la historia médica.
        /// </summary>
        
        public string Diagnostico { get; set; }

        /// <summary>
        /// Lista de órdenes incluidas en esta factura.
        /// </summary>
        
        public List<Orden> Ordenes { get; set; }

        /// <summary>
        /// Monto total a pagar.
        /// </summary>
        
        public decimal TotalBruto { get; set; }

        /// <summary>
        /// Valor que paga el paciente (copago).
        /// </summary>
        
        public decimal Copago { get; set; }

        /// <summary>
        /// Valor cubierto por la aseguradora.
        /// </summary>
        
        public decimal CubiertoPorSeguro => TotalBruto - Copago;

        public Facturacion()
        {
            Fecha = DateTime.Now;
            Ordenes = new List<Orden>();
        }
    }
}
