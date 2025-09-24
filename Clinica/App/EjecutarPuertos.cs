using Clinica.App.Puertos;
using Clinica.Models;
using Clinica.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.App
{
    public static class EjecutarPuertos
    {
        public static void EjecutarTodo()
        {
            // Servicios
            var pacienteService = new PacienteService();
            var usuarioService = new UsuarioService();
            var ordenService = new OrdenService();
            var registroService = new RegistroMedicoService();
            var visitaService = new VisitaService();
            var facturacionService = new FacturacionService();

            // Paciente
            CrearPaciente.Ejecutar(pacienteService);
            ActualizarPaciente.Ejecutar(pacienteService);
            BuscarPaciente.Ejecutar(pacienteService);

            // Empleado
            CrearEmpleado.Ejecutar(usuarioService);
            ActualizarEmpleado.Ejecutar(usuarioService);
            LoginEmpleado.Ejecutar(usuarioService);

            // Datos base para pruebas siguientes
            var paciente = pacienteService.BuscarPorCedula("1010");
            var medico = usuarioService.Login("lauraruiz", "NuevaContraseña1!");

            // Orden
            CrearOrden.Ejecutar(ordenService, paciente, medico);
            BuscarOrden.Ejecutar(ordenService);
            var orden = ordenService.BuscarPorNumero(1001);

            // Registro médico
            var registro = CrearRegistroMedico.Ejecutar(registroService, paciente, medico, orden);
            ActualizarRegistroMedico.Ejecutar(registroService, registro.Id);
            BuscarRegistroMedico.Ejecutar(registroService, paciente.Cedula);

            // Visita
            CrearVisita.Ejecutar(visitaService, paciente, medico);

            // Factura
            CrearFactura.Ejecutar(facturacionService, paciente, medico, new List<Orden> { orden }, registro.Diagnostico);

        }
    }
}
