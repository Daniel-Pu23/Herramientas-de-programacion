using Clinica.Application.OutputPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Adapters
{
    public static class ActualizarPacienteConsola
    {
        public static void Ejecutar(IRepositorioPaciente repositorio)
        {
            var paciente = repositorio.BuscarPorCedula("10101010");
            if (paciente == null)
            {
                Console.WriteLine("Paciente no encontrado para actualizar.");
                return;
            }

            paciente.Telefono = "3219876543";
            Console.WriteLine($"Teléfono actualizado a: {paciente.Telefono}");
        }
    }
}
