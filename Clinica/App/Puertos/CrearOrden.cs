using Clinica.Models;
using Clinica.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.App.Puertos
{
    public static class CrearOrden
    {
        public static void Ejecutar(OrdenService service, Paciente paciente, Usuario medico)
        {
            var orden = new Orden
            {
                NumeroOrden = 1001,
                CedulaPaciente = paciente.Cedula,
                CedulaMedico = medico.Cedula
            };

            var medicamento = new Medicamento
            {
                Id = 101,
                Nombre = "Ibuprofeno",
                Presentacion = "Tabletas",
                PrecioUnidad = 2000,
                Stock = 50
            };

            var item = new OrdenMedicamento
            {
                NumeroOrden = orden.NumeroOrden,
                NumeroItem = 1,
                Medicamento = medicamento,
                Dosis = "1 cada 8h",
                DiasDuracion = 3
            };
            item.CalcularCosto();

            orden.Items.Add(item);

            var exito = service.RegistrarOrden(orden);

            Console.WriteLine(exito
                ? "Orden médica registrada."
                : "No se pudo registrar la orden.");
        }
    }
}
