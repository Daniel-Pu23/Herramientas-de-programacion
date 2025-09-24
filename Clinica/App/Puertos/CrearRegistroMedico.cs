using Clinica.Models;
using Clinica.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.App.Puertos
{
    public static class CrearRegistroMedico
    {
        public static RegistroMedico Ejecutar(RegistroMedicoService service, Paciente paciente, Usuario medico, Orden orden)
        {
            var registro = new RegistroMedico
            {
                Paciente = paciente,
                Medico = medico,
                MotivoConsulta = "Dolor abdominal",
                Diagnostico = "Gastritis",
                Ordenes = new List<Orden> { orden }
            };

            var exito = service.CrearRegistro(registro);

            Console.WriteLine(exito
                ? "Registro médico creado."
                : "No se pudo crear el registro médico.");

            return registro;
        }
    }
}
