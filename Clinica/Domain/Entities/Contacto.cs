using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Representa el contacto de emergencia del paciente.
    /// </summary>
    
    public class Contacto
    {
        /// <summary>
        /// Nombres del contacto de emergencia.
        /// </summary>
        
       public string Nombres { get; set; }

        /// <summary>
        /// Apellidos del contacto de emergencia.
        /// </summary>
        
        public string Apellidos { get; set; }

        /// <summary>
        /// Relacion del contacto con el paciente.
        /// </summary>
        
        public string Relacion { get; set; }

        /// <summary>
        /// Numero de telefono del contacto (10 digitos)
        /// </summary>
        
        public string Telefono { get; set; }

        /// <summary>
        /// Valida que el telefono contenga exactamente 10 dijitos numericos
        /// </summary>
        
        public bool TelefonoValido()
        {
            return !string.IsNullOrWhiteSpace(Telefono) &&
                Telefono.Length == 10 &&
                Regex.IsMatch(Telefono, @"^\d{10}$");
        }

        /// <summary>
        /// Verifica que el contacto tenga nombres y apellidos.
        /// </summary>
        
        public bool NombreCompletoValido()
        {
            return !string.IsNullOrWhiteSpace(Nombres) && !string.IsNullOrWhiteSpace(Apellidos);
        }

        /// <summary>
        /// Verifica que se haya definido la relacion con el paciente.
        /// </summary>
        
        public bool RelacionValida()
        {
            return !string.IsNullOrWhiteSpace(Relacion);
        }
    }
}
