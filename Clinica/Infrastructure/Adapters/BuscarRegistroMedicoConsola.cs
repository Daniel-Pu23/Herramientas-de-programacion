using Clinica.Application.OutputPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Adapters
{
    public static class BuscarRegistroMedicoConsola
    {
        public static void Ejecutar(IRepositorioRegistroMedico repositorio)
        {
            Console.WriteLine("Buscar primer registro médico del sistema:");
            var registros = repositorio.ObtenerTodos();

            if (registros.Any())
            {
                var r = registros.First();
                Console.WriteLine($"Registro encontrado: {r.FechaRegistro}, Diagnóstico: {r.Diagnostico}");
            }
            else
            {
                Console.WriteLine("No hay registros médicos.");
            }
        }
    }
}
