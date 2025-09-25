using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public enum RolUsuario
    {
        Medico,
        Enfermera,
        Administrativo,
        RecursosHumanos,
        Soporte
    }
    
    public class Usuario
    {
        public string Cedula { get; set; }
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public RolUsuario Rol { get; set; }
    }
}
