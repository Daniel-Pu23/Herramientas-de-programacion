using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class OrdenMedicamento : ItemOrden
    {
        public string NombreMedicamento { get; set; }
        public string Dosis { get; set; }
        public int DiasTratamiento { get; set; }

        public override string Describir()
        {
            return $"{NombreMedicamento} - {Dosis} x {DiasTratamiento} días";
        }
    }
}
