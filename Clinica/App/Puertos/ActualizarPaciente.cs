using Clinica.Models;
using Clinica.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.App.Puertos
{
    public static class ActualizarPaciente
    {
        public static void Ejecutar(PacienteService service)
        {
            var actualizado = new Paciente
            {
                Cedula = "1010",
                NombreCompleto = "Carlos Gomez Actualizado",
                CorreoElectronico = "nuevo@email.com",
                Telefono = "3001112222",
                Direccion = "Nueva dirección",
                FechaNacimiento = new DateTime(1990, 1, 1),
                ContactoEmergencia = new Contacto
                {
                    Nombres = "Camila",
                    Apellidos = "Gomez",
                    Relacion = "Esposa",
                    Telefono = "3012345678"
                },
                Seguro = new SeguroMedico
                {
                    NombreCompania = "Nueva EPS",
                    NumeroPoliza = "ACT987",
                    Activa = true,
                    VigenteHasta = DateTime.Today.AddMonths(12)
                }
            };

            var exito = service.ActualizarDatos("1010", actualizado);

            Console.WriteLine(exito
                ? "Datos del paciente actualizados correctamente."
                : "No se encontró el paciente para actualizar.");
        }
    }
}
