using Clinica.Application.OutputPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Adapters
{
    public static class BuscarPacienteConsola
    {
        public static void Ejecutar(IRepositorioPaciente repositorio)
        {
            Console.WriteLine("Buscar paciente por cédula:");
            string cedula = "10101010";

            var paciente = repositorio.BuscarPorCedula(cedula);
            if (paciente != null)
            {
                Console.WriteLine($"Paciente encontrado: {paciente.NombreCompleto} - Tel: {paciente.Telefono}");
            }
            else
            {
                Console.WriteLine("Paciente no encontrado.");
            }
        }
    }
}
