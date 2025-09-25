using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public abstract class ItemOrden
    {
        public int NumeroItem { get; set; }
        public decimal Costo { get; set; }

        public abstract string Describir();
    }
}
