using Clinica.Models;
using Clinica.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.App.Puertos
{
    public static class ActualizarEmpleado
    {
        public static void Ejecutar(UsuarioService service)
        {
            var actualizado = new Usuario
            {
                Cedula = "9999",
                NombreCompleto = "Laura Ruiz Actualizada",
                CorreoElectronico = "laura.actualizada@clinica.com",
                Telefono = "3040001122",
                Direccion = "Nueva dirección 123",
                FechaNacimiento = new DateTime(1987, 5, 20),
                NombreUsuario = "lauraruiz",
                Contrasena = "NuevaContraseña1!",
                Rol = RolUsuario.Enfermera
            };

            var encontrado = service.Login(actualizado.NombreUsuario, "Laura2023!");
            if (encontrado == null)
            {
                Console.WriteLine("No se encontró el usuario a actualizar.");
                return;
            }

            encontrado.NombreCompleto = actualizado.NombreCompleto;
            encontrado.CorreoElectronico = actualizado.CorreoElectronico;
            encontrado.Telefono = actualizado.Telefono;
            encontrado.Direccion = actualizado.Direccion;
            encontrado.Contrasena = actualizado.Contrasena;

            Console.WriteLine("Empleado actualizado correctamente.");
        }
    }
}
