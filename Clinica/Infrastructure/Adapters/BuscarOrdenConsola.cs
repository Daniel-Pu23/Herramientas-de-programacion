using Clinica.Application.OutputPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Adapters
{
    public static class BuscarOrdenConsola
    {
        public static void Ejecutar(IRepositorioOrden repositorio)
        {
            Console.WriteLine("Buscar orden por ID:");
            var ordenes = repositorio.ObtenerTodas();

            if (ordenes.Count > 0)
            {
                var orden = ordenes.First();
                Console.WriteLine($"Orden encontrada con ID: {orden.Id}, Ítems: {orden.Items.Count}");
            }
            else
            {
                Console.WriteLine("No hay órdenes registradas.");
            }
        }
    }
}
