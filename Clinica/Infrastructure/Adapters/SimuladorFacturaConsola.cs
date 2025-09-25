using Clinica.Application.InputPorts;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Adapters
{
    public static class SimuladorFacturaConsola
    {
        public static void Ejecutar(IPuertoEntradaFactura servicioFactura)
        {
            var paciente = new Paciente
            {
                Cedula = "99999999",
                NombreCompleto = "Esteban Ramírez",
                Telefono = "3001112223",
                Direccion = "Calle 20 #15-55",
                CorreoElectronico = "esteban@correo.com",
                FechaNacimiento = new DateTime(1992, 7, 20)
            };

            var factura = new Factura
            {
                Paciente = paciente,
                ValorTotal = 7500,
                Descripcion = "Orden de medicamentos y exámenes"
            };

            var creada = servicioFactura.CrearFactura(factura);
            Console.WriteLine(creada ? "Factura creada correctamente" : "Error al crear factura");

            Console.WriteLine("\nFacturas registradas:");
            foreach (var f in servicioFactura.ListarFacturas())
            {
                Console.WriteLine(f.ObtenerResumen());
            }
        }
    }
}
