using Clinica.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.App.Puertos
{
    public static class BuscarRegistroMedico
    {
        public static void Ejecutar(RegistroMedicoService service, string cedula)
        {
            var registros = service.BuscarPorPaciente(cedula);

            if (registros.Count == 0)
                Console.WriteLine("No se encontraron registros médicos.");
            else
                Console.WriteLine($"Se encontraron {registros.Count} registro(s) médico(s) del paciente.");
        }
    }
}
