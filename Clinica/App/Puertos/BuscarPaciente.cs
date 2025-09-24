using Clinica.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.App.Puertos
{
    public static class BuscarPaciente
    {
        public static void Ejecutar(PacienteService service)
        {
            var paciente = service.BuscarPorCedula("1010");

            if (paciente == null)
            {
                Console.WriteLine("No se encontró paciente con esa cédula.");
            }
            else
            {
                Console.WriteLine($"Paciente encontrado: {paciente.NombreCompleto}, {paciente.Telefono}, {paciente.Direccion}");
            }
        }
    }
}
