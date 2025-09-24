using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Representa un usuario del sistema que hereda de Persona.
    /// </summary>
    
    public class Usuario : Persona
    {
        /// <summary>
        /// Rol que desempeña el usuario en la clinica
        /// </summary>
        
        public RolUsuario Rol {get; set; }

        /// <summary>
        /// Nombre de usuario unico, maximo 15 caracteres, letras y numeros.
        /// </summary>
        
        public string NombreUsuario {get; set; }

        /// <summary>
        /// Contraseña del usuario, debe cumplir con requisitos de seguridad
        /// </summary>
        
        public string Contrasena {get; set; }

        /// <summary>
        /// Verifica que el nombre de usuario tenga un formato valido.
        /// </summary>
        /// <returns>True si es valido, false si no.</returns>
        
        public bool NombreUsuarioValido()
        {
            if (string.IsNullOrWhiteSpace(NombreUsuario)) return false;
            if (NombreUsuario.Length > 15) return false;

            return Regex.IsMatch(NombreUsuario, @"^[a-zA-Z0-9]+$");
        }

        /// <summary>
        /// Valida que la contraseña tenga al menos 8 caracteres, una mayuscula,un numero y un caracter especial.
        /// </summary>
        
        public bool ContrasenaValida()
        {
            if (string.IsNullOrWhiteSpace(Contrasena) || Contrasena.Length < 8)
                return false;

            return Regex.IsMatch(Contrasena, @"^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*]).{8,}$");
        }

    }

    /// <summary>
    /// Enum para representar los roles posibles de un usuario.
    /// </summary>
    
    public enum RolUsuario
    {
        Medico,
        Enfermera,
        Administrativo,
        RecursosHumanos,
        Soporte
    }
}
