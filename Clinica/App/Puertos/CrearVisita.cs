using Clinica.Models;
using Clinica.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.App.Puertos
{
    public static class CrearVisita
    {
        public static void Ejecutar(VisitaService service, Paciente paciente, Usuario enfermera)
        {
            var visita = new Visita
            {
                Paciente = paciente,
                Enfermera = enfermera,
                DatosVitales = new DatosVitales
                {
                    PresionArterial = "120/80",
                    Temperatura = 36.7f,
                    Pulso = 72,
                    Oxigeno = 98
                },
                Observaciones = "Paciente en buenas condiciones generales."
            };

            var exito = service.CrearVisita(visita);

            Console.WriteLine(exito
                ? "Visita registrada correctamente."
                : "No se pudo registrar la visita.");
        }
    }
}
