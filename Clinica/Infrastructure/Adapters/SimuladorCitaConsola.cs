using Clinica.Application.InputPorts;
using Clinica.Domain.Entities;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Adapters
{
    public static class SimuladorCitaConsola
    {
        public static void Ejecutar(IPuertoEntradaCita servicio)
        {
            var paciente = new Paciente
            {
                Cedula = "123456789",
                NombreCompleto = "Carlos Ramírez",
                Telefono = "3012345678",
                Direccion = "Calle 100 #20-30",
                CorreoElectronico = "carlos@correo.com",
                FechaNacimiento = new DateTime(1990, 5, 10)
            };

            var profesional = new Usuario
            {
                Cedula = "987654321",
                NombreCompleto = "Dra. Fernanda Ruiz",
                NombreUsuario = "fernanda.ruiz",
                Contrasena = "clave123",
                Rol = RolUsuario.Medico
            };

            var cita = new Cita
            {
                FechaHora = DateTime.Now.AddDays(2),
                Paciente = paciente,
                Profesional = profesional,
                Motivo = "Chequeo general"
            };

            bool agendada = servicio.ProgramarCita(cita);
            Console.WriteLine(agendada ? "Cita agendada correctamente" : "No se pudo agendar la cita");

            Console.WriteLine("\nCitas registradas:");
            foreach (var c in servicio.ListarCitas())
            {
                Console.WriteLine($"▶ {c.FechaHora} - {c.Paciente.NombreCompleto} con {c.Profesional.NombreCompleto} ({c.Motivo})");
            }
        }
    }
}
