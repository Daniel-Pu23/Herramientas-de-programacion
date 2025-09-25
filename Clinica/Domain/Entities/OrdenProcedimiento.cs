using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class OrdenProcedimiento : ItemOrden
    {
        public string NombreProcedimiento { get; set; }
        public int Repeticiones { get; set; }

        public override string Describir()
        {
            return $"{NombreProcedimiento} x {Repeticiones} veces";
        }
    }
}
