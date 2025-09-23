using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Representa a un paciente de la clinica, hereda de persona.
    /// </summary>
    
    public class Paciente : Persona
    {
        /// <summary>
        /// Genero del paciente (Masculino, Femenino).
        /// </summary>
        
        public Genero Genero { get; set; }

        /// <summary>
        /// Contacto de emergencia del paciente.
        /// </summary>
        
        public Contacto ContactoEmergencia { get; set; }

        /// <summary>
        /// Seguro meduco actual del paciente (puede ser null).
        /// </summary>
        
        public SeguroMedico Seguro { get; set; }

        /// <summary>
        /// Constructor con inicialización de objectos embebidos.
        /// </summary>
        
        public Paciente()
        {
            ContactoEmergencia = new Contacto();
            Seguro = new SeguroMedico();
        }

        /// <summary>
        /// Verifica si el paciente tiene seguro activo y vigente.
        /// </summary>
       
        public bool TieneSeguroActivo()
        {
            if (Seguro == null) return false;
            return Seguro.EstaActiva() && Seguro.VigenteHasta >= DateTime.Today;
        }
    }

    /// <summary>
    /// Enum para representar al genero del paciente.
    /// </summary>
    
    public enum Genero
    {
        Masculino,
        Femenino
    }
}
