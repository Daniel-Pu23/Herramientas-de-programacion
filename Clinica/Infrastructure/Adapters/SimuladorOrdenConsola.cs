using Clinica.Application.InputPorts;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Adapters
{
    public static class SimuladorOrdenConsola
    {
        public static void Ejecutar(IPuertoEntradaOrden servicioOrden)
        {
            var orden = new Orden();
            orden.Items.Add(new OrdenMedicamento
            {
                NombreMedicamento = "Amoxicilina",
                Dosis = "500mg",
                DiasTratamiento = 7,
                Costo = 7500
            });

            var creada = servicioOrden.CrearOrden(orden);
            Console.WriteLine(creada ? "Orden creada correctamente" : "Error al crear la orden");

            Console.WriteLine("\nÓrdenes registradas:");
            foreach (var o in servicioOrden.ListarOrdenes())
            {
                Console.WriteLine($"- Orden {o.Id} con {o.Items.Count} ítems:");
                foreach (var item in o.Items)
                {
                    Console.WriteLine($"  {item.Describir()} - ${item.Costo:N0}");
                }
                Console.WriteLine($"Total: ${o.CalcularTotal():N0}\n");
            }
        }
    }
}
