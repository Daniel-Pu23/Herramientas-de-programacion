using Clinica.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.App.Puertos
{
    public static class ActualizarRegistroMedico
    {
        public static void Ejecutar(RegistroMedicoService service, Guid idRegistro)
        {
            var exito = service.ActualizarRegistro(idRegistro, "Gastritis crónica con seguimiento");

            Console.WriteLine(exito
                ? "Diagnóstico actualizado correctamente."
                : "No se pudo actualizar el diagnóstico.");
        }
    }
}
