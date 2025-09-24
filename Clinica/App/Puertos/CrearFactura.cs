using Clinica.Models;
using Clinica.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.App.Puertos
{
    public static class CrearFactura
    {
        public static void Ejecutar(FacturacionService service, Paciente paciente, Usuario medico, List<Orden> ordenes, string diagnostico)
        {
            var factura = new Facturacion
            {
                Paciente = paciente,
                Medico = medico,
                Diagnostico = diagnostico,
                Ordenes = ordenes
            };

            var exito = service.CrearFactura(factura);

            Console.WriteLine(exito
                ? $"Factura generada. Total: {factura.TotalBruto:C} | Copago: {factura.Copago:C}"
                : "No se pudo generar la factura.");
        }
    }
}
