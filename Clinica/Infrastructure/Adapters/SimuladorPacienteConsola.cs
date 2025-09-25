using Clinica.Application.InputPorts;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Adapters
{
    public static class SimuladorPacienteConsola
    {
        public static void Ejecutar(IPuertoEntradaPaciente servicioPaciente)
        {
            var paciente = new Paciente
            {
                Cedula = "10101010",
                NombreCompleto = "Carlos Gómez",
                Telefono = "3001122334",
                Direccion = "Av. Principal 456",
                CorreoElectronico = "carlos.gomez@correo.com",
                FechaNacimiento = new DateTime(1995, 4, 15)
            };

            var registrado = servicioPaciente.RegistrarPaciente(paciente);
            Console.WriteLine(registrado ? "Paciente registrado correctamente" : "Error al registrar paciente");

            var encontrado = servicioPaciente.BuscarPorCedula("10101010");
            if (encontrado != null)
                Console.WriteLine($"Paciente encontrado: {encontrado.NombreCompleto}");
            else
                Console.WriteLine("Paciente no encontrado");
        }
    }
}
