using Clinica.Application.InputPorts;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Adapters
{
    public static class SimuladorVisitaConsola
    {
        public static void Ejecutar(IPuertoEntradaVisita servicioVisita)
        {
            var paciente = new Paciente
            {
                Cedula = "88888888",
                NombreCompleto = "Marcela Torres",
                Telefono = "3124445566",
                Direccion = "Transversal 8 #10-20",
                CorreoElectronico = "marcela@correo.com",
                FechaNacimiento = new DateTime(1988, 3, 12)
            };

            var profesional = new Usuario
            {
                Cedula = "12345678",
                NombreCompleto = "Dr. Gustavo Pérez",
                NombreUsuario = "gustavo.p",
                Contrasena = "clave456",
                Rol = RolUsuario.Medico
            };

            var visita = new Visita
            {
                Paciente = paciente,
                Profesional = profesional,
                MotivoConsulta = "Dolor abdominal agudo",
                Observaciones = "Se recomienda ecografía abdominal"
            };

            var registrada = servicioVisita.RegistrarVisita(visita);
            Console.WriteLine(registrada ? "Visita registrada correctamente" : "Error al registrar visita");

            Console.WriteLine("\nVisitas registradas:");
            foreach (var v in servicioVisita.ListarVisitas())
            {
                Console.WriteLine($"- {v.FechaHora}: {v.Paciente.NombreCompleto} atendido por {v.Profesional.NombreCompleto} — Motivo: {v.MotivoConsulta}");
            }
        }
    }
}
