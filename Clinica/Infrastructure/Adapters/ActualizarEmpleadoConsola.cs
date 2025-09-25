using Clinica.Application.OutputPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Adapters
{
    public static class ActualizarEmpleadoConsola
    {
        public static void Ejecutar(IRepositorioUsuario repositorio)
        {
            var usuario = repositorio.BuscarPorNombreUsuario("laura.l");
            if (usuario == null)
            {
                Console.WriteLine("Usuario no encontrado.");
                return;
            }

            usuario.CorreoElectronico = "nuevo.correo@correo.com";
            Console.WriteLine($"Correo actualizado: {usuario.CorreoElectronico}");
        }
    }
}
