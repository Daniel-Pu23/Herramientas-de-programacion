using Clinica.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.App.Puertos
{
    public static class BuscarOrden
    {
        public static void Ejecutar(OrdenService service)
        {
            var orden = service.BuscarPorNumero(1001);

            if (orden == null)
                Console.WriteLine("Orden no encontrada.");
            else
                Console.WriteLine($"Orden #{orden.NumeroOrden} encontrada con {orden.Items.Count} ítem(s).");
        }
    }
}
