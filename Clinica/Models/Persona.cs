using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public abstract class Persona
    {
        public string Cedula { get; set; }
        public string NombreCompleto { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }

        /// <summary>
        /// Retorna la edad de la persona según la fecha actual.
        /// </summary>
        
        public int ObtenerEdad()
        {
            var hoy = DateTime.Today;
            var edad = hoy.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > hoy.AddYears(-edad)) edad--;
            return edad;
        }

        /// <summary>
        /// Valida si el correo electronico tiene un formato valido.
        /// </summary>
        
        public bool CorreoValido()
        {
            if (string.IsNullOrWhiteSpace(CorreoElectronico)) return false;

            var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(CorreoElectronico);
        }

        /// <summary>
        /// Valida que el telefono tenga entre 1 y 10 digitos.
        /// </summary>
        
        public bool TelefonoValido()
        {
            return !string.IsNullOrWhiteSpace(Telefono) && Telefono.Length <= 10 && Telefono.All(char.IsDigit);
        }

        /// <summary>
        /// Valida que la persona no tenga mas de 150 años.
        /// </summary>
        
        public bool EdadValida()
        {
            return ObtenerEdad() <= 150;
        }
    }
}
