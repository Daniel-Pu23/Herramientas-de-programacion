using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Factura
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime FechaEmision { get; set; } = DateTime.Now;

        public Paciente Paciente { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorCopago { get; set; }

        public string Descripcion { get; set; }

        public string ObtenerResumen()
        {
            return $"Factura creada para paciente {Paciente?.NombreCompleto} por valor total: $ {ValorTotal:N2} | Copago: $ {ValorCopago:N2}";
        }
    }
}
