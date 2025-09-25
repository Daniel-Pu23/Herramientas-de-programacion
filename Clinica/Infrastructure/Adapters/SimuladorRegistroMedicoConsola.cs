using Clinica.Application.InputPorts;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Adapters
{
    public static class SimuladorRegistroMedicoConsola
    {
        public static void Ejecutar(IPuertoEntradaRegistroMedico servicioRegistro)
        {
            var paciente = new Paciente
            {
                Cedula = "77777777",
                NombreCompleto = "Lucía Andrade",
                Telefono = "3104448899",
                Direccion = "Calle 30 #25-50",
                CorreoElectronico = "lucia@correo.com",
                FechaNacimiento = new DateTime(1990, 2, 18)
            };

            var profesional = new Usuario
            {
                Cedula = "22222222",
                NombreCompleto = "Dra. Paula Jiménez",
                NombreUsuario = "paula.j",
                Contrasena = "clave789",
                Rol = RolUsuario.Medico
            };

            var orden = new Orden();
            orden.Items.Add(new OrdenAyudaDiagnostica
            {
                TipoEstudio = "Rayos X de tórax",
                Indicaciones = "Paciente con tos persistente",
                Costo = 15000
            });

            var registro = new RegistroMedico
            {
                Paciente = paciente,
                Profesional = profesional,
                Diagnostico = "Bronquitis aguda",
                Tratamiento = "Reposo y analgésicos",
                Observaciones = "Requiere control en 5 días",
                OrdenMedica = orden
            };

            var creado = servicioRegistro.CrearRegistro(registro);
            Console.WriteLine(creado ? "Registro médico creado correctamente" : "Error al crear registro médico");

            Console.WriteLine("\nRegistros médicos:");
            foreach (var r in servicioRegistro.ListarRegistros())
            {
                Console.WriteLine($"- {r.FechaRegistro}: {r.Paciente.NombreCompleto} atendido por {r.Profesional.NombreCompleto} — Diagnóstico: {r.Diagnostico}");
                if (r.OrdenMedica != null)
                    Console.WriteLine($"  ▶ Orden médica con {r.OrdenMedica.Items.Count} ítems");
            }
        }
    }
}
