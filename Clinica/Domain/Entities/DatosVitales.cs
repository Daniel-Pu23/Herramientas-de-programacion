using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class DatosVitales
    {
        public DateTime FechaHora { get; set; } = DateTime.Now;

        public float Temperatura { get; set; }           // °C
        public int FrecuenciaCardiaca { get; set; }      // latidos por minuto
        public int FrecuenciaRespiratoria { get; set; }  // respiraciones por minuto
        public int PresionSistolica { get; set; }        // mmHg
        public int PresionDiastolica { get; set; }       // mmHg
        public int SaturacionOxigeno { get; set; }       // %

        public string Descripcion()
        {
            return $"Temp: {Temperatura}°C, FC: {FrecuenciaCardiaca} lpm, FR: {FrecuenciaRespiratoria} rpm, PA: {PresionSistolica}/{PresionDiastolica} mmHg, SO2: {SaturacionOxigeno}%";
        }
    }
}
