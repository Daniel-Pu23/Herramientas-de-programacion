using Clinica.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.App.Puertos
{
    public static class LoginEmpleado
    {
        public static void Ejecutar(UsuarioService service)
        {
            var usuario = service.Login("lauraruiz", "NuevaContraseña1!");

            if (usuario == null)
            {
                Console.WriteLine("Login fallido. Usuario o contraseña incorrectos.");
            }
            else
            {
                Console.WriteLine($"Login exitoso. Bienvenida, {usuario.NombreCompleto} ({usuario.Rol}).");
            }
        }
    }
}
