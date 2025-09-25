using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Orden
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public List<ItemOrden> Items { get; set; } = new List<ItemOrden>();

        public decimal CalcularTotal()
        {
            return Items.Sum(i => i.Costo);
        }
    }
}
