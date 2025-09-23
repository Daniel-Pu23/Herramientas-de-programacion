using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Representa los datos vitales registrados durante una visita medica.
    /// </summary>
    
    public class DatosVitales
    {
        /// <summary>
        /// Presión arterial del paciente.
        /// </summary>
        
        public string PresionArterial { get; set; }

        /// <summary>
        /// Temperatura corporal en grados Celsius.
        /// </summary>
        
        public float Temperatura { get; set; }

        /// <summary>
        /// Pulso cardíaco en latidos por minuto.
        /// </summary>
        
        public int Pulso { get; set; }

        /// <summary>
        /// Nivel de oxígeno en la sangre (SpO2, en %).
        /// </summary>
        
        public int Oxigeno { get; set; }

        /// <summary>
        /// Verifica que todos los datos vitales tengan valores aceptables.
        /// </summary>
        
        public bool DatosValidos()
        {
            return Temperatura >= 30 && Temperatura <= 45 &&
                   Pulso >= 30 && Pulso <= 200 &&
                   Oxigeno >= 50 && Oxigeno <= 100 &&
                   !string.IsNullOrWhiteSpace(PresionArterial);
        }
    }
}
