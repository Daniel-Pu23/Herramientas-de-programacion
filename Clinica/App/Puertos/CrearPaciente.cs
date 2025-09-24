using Clinica.Models;
using Clinica.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.App.Puertos
{
    public static class CrearPaciente
    {
        public static void Ejecutar(PacienteService service)
        {
            var paciente = new Paciente
            {
                Cedula = "1010",
                NombreCompleto = "Carlos Gomez",
                CorreoElectronico = "carlos@gomez.com",
                Telefono = "3005550000",
                Direccion = "Cra 1 #1-1",
                FechaNacimiento = new DateTime(1990, 1, 1),
                Genero = Genero.Masculino,
                ContactoEmergencia = new Contacto
                {
                    Nombres = "Sofia",
                    Apellidos = "Gomez",
                    Relacion = "Hermana",
                    Telefono = "3009999999"
                },
                Seguro = new SeguroMedico
                {
                    NombreCompania = "EPS Global",
                    NumeroPoliza = "EPS123",
                    Activa = true,
                    VigenteHasta = DateTime.Today.AddYears(1)
                }
            };

            var resultado = service.RegistrarPaciente(paciente);

            Console.WriteLine(resultado
                ? "Paciente registrado exitosamente."
                : "No se pudo registrar al paciente (ya existe o datos inválidos).");
        }
    }
}
