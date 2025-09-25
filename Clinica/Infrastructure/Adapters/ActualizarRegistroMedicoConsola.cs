using Clinica.Application.OutputPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Adapters
{
    public static class ActualizarRegistroMedicoConsola
    {
        public static void Ejecutar(IRepositorioRegistroMedico repositorio)
        {
            var registros = repositorio.ObtenerTodos();
            var registro = registros.FirstOrDefault();

            if (registro == null)
            {
                Console.WriteLine("No hay registros para actualizar.");
                return;
            }

            registro.Observaciones += " | Actualización posterior";
            Console.WriteLine($"Registro actualizado: {registro.Observaciones}");
        }
    }
}
