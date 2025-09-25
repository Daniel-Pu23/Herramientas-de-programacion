using Clinica.Application.InputPorts;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Adapters
{
    public static class SimuladorUsuarioConsola
    {
        public static void Ejecutar(IPuertoEntradaUsuario servicioUsuario)
        {
            var nuevoUsuario = new Usuario
            {
                Cedula = "11223344",
                NombreCompleto = "Laura López",
                Telefono = "3112223344",
                Direccion = "Calle Falsa 123",
                CorreoElectronico = "laura@example.com",
                NombreUsuario = "laura.l",
                Contrasena = "clave123",
                FechaNacimiento = new DateTime(1990, 5, 10),
                Rol = RolUsuario.Medico
            };

            var registrado = servicioUsuario.RegistrarUsuario(nuevoUsuario);
            Console.WriteLine(registrado ? "Usuario registrado" : "Error al registrar usuario");

            var login = servicioUsuario.IniciarSesion("laura.l", "clave123");
            Console.WriteLine(login != null ? $"Login exitoso: {login.NombreCompleto}" : "Login fallido");
        }
    }
}
