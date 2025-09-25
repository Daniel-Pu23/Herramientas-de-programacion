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
    public static class SimuladorHistoriaClinicaConsola
    {
        public static void Ejecutar(IPuertoEntradaHistoriaClinica servicioHistoria)
        {
            var paciente = new Paciente
            {
                Cedula = "55555555",
                NombreCompleto = "Julián Salazar",
                Telefono = "3203344556",
                Direccion = "Calle 45 #67-89",
                CorreoElectronico = "julian@correo.com",
                FechaNacimiento = new DateTime(1991, 9, 5)
            };

            var profesional = new Usuario
            {
                Cedula = "11111111",
                NombreCompleto = "Dra. Karen Núñez",
                NombreUsuario = "karen.n",
                Contrasena = "clave1010",
                Rol = RolUsuario.Medico
            };

            var registro = new RegistroMedico
            {
                Paciente = paciente,
                Profesional = profesional,
                Diagnostico = "Gripe común",
                Tratamiento = "Reposo e hidratación",
                Observaciones = "Sin signos de alarma"
            };

            var historia = new HistoriaClinica
            {
                Paciente = paciente,
                RegistrosMedicos = new List<RegistroMedico> { registro }
            };

            var creada = servicioHistoria.CrearHistoria(historia);
            Console.WriteLine(creada ? "Historia clínica creada correctamente" : "Error al crear historia clínica");

            Console.WriteLine("\nHistorias clínicas registradas:");
            foreach (var h in servicioHistoria.ListarHistorias())
            {
                Console.WriteLine($"Paciente: {h.Paciente.NombreCompleto} - Registros: {h.RegistrosMedicos.Count}");
                foreach (var r in h.RegistrosMedicos)
                {
                    Console.WriteLine($" ▶ {r.FechaRegistro}: {r.Diagnostico} - {r.Tratamiento}");
                }
            }
        }
    }
}
