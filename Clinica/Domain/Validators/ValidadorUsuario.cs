using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clinica.Domain.Validators
{
    public class ValidadorUsuario : IValidadorUsuario
    {
        public bool EsValido(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.NombreCompleto) ||
                string.IsNullOrWhiteSpace(usuario.NombreUsuario) ||
                string.IsNullOrWhiteSpace(usuario.Contrasena))
                return false;

            if (!Regex.IsMatch(usuario.Telefono ?? "", @"^\d{10}$"))
                return false;

            if (!Regex.IsMatch(usuario.CorreoElectronico ?? "", @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return false;

            if (usuario.Contrasena.Length < 6)
                return false;

            return true;
        }
    }
}
