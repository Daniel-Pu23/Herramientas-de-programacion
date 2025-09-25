using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class OrdenAyudaDiagnostica : ItemOrden
    {
        public string TipoEstudio { get; set; }
        public string Indicaciones { get; set; }

        public override string Describir()
        {
            return $"{TipoEstudio} - {Indicaciones}";
        }
    }
}
