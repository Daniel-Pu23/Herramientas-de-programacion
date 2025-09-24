using Clinica.Models;
using Clinica.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.App.Puertos
{
    public static class CrearEmpleado
    {
        public static void Ejecutar(UsuarioService service)
        {
            var empleado = new Usuario
            {
                Cedula = "9999",
                NombreCompleto = "Laura Ruiz",
                CorreoElectronico = "laura@clinica.com",
                Telefono = "3041112233",
                Direccion = "Av. Siempre Viva 742",
                FechaNacimiento = new DateTime(1987, 5, 20),
                NombreUsuario = "lauraruiz",
                Contrasena = "Laura2023!",
                Rol = RolUsuario.Enfermera
            };

            var resultado = service.RegistrarUsuario(empleado);

            Console.WriteLine(resultado
                ? "Empleado registrado exitosamente."
                : "No se pudo registrar el empleado (usuario ya existe o datos inválidos).");
        }
    }
}

