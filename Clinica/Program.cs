using Clinica;
using Clinica.Application.InputPorts;
using Clinica.Domain.Services;
using Clinica.Domain.Validators;
using Clinica.Infrastructure.Adapters;
using Clinica.Infrastructure.Repositories;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // USUARIO
            var repositorioUsuario = new RepositorioUsuarioEnMemoria();
            var validadorUsuario = new ValidadorUsuario();
            IPuertoEntradaUsuario servicioUsuario = new ServicioUsuario(repositorioUsuario, validadorUsuario);
            SimuladorUsuarioConsola.Ejecutar(servicioUsuario);

            // PACIENTE
            var repositorioPaciente = new RepositorioPacienteEnMemoria();
            var validadorPaciente = new ValidadorPaciente();
            IPuertoEntradaPaciente servicioPaciente = new ServicioPaciente(repositorioPaciente, validadorPaciente);
            SimuladorPacienteConsola.Ejecutar(servicioPaciente);

            // ORDEN
            var repositorioOrden = new RepositorioOrdenEnMemoria();
            var validadorOrden = new ValidadorOrden();
            IPuertoEntradaOrden servicioOrden = new ServicioOrden(repositorioOrden, validadorOrden);
            SimuladorOrdenConsola.Ejecutar(servicioOrden);

            // FACTURACIÓN
            var repositorioFactura = new RepositorioFacturaEnMemoria();
            IPuertoEntradaFactura servicioFactura = new ServicioFactura(repositorioFactura);
            SimuladorFacturaConsola.Ejecutar(servicioFactura);

            // VISITA
            var repositorioVisita = new RepositorioVisitaEnMemoria();
            IPuertoEntradaVisita servicioVisita = new ServicioVisita(repositorioVisita);
            SimuladorVisitaConsola.Ejecutar(servicioVisita);

            // REGISTRO MÉDICO
            var repositorioRegistro = new RepositorioRegistroMedicoEnMemoria();
            IPuertoEntradaRegistroMedico servicioRegistro = new ServicioRegistroMedico(repositorioRegistro);
            SimuladorRegistroMedicoConsola.Ejecutar(servicioRegistro);

            // HISTORIA CLÍNICA
            var repositorioHistoria = new RepositorioHistoriaClinicaEnMemoria();
            IPuertoEntradaHistoriaClinica servicioHistoria = new ServicioHistoriaClinica(repositorioHistoria);
            SimuladorHistoriaClinicaConsola.Ejecutar(servicioHistoria);

            //CITA
            var repositorioCita = new RepositorioCitaEnMemoria();
            IPuertoEntradaCita servicioCita = new ServicioCita(repositorioCita);
            SimuladorCitaConsola.Ejecutar(servicioCita);

            // FUNCIONALIDADES FINALES
            BuscarPacienteConsola.Ejecutar(repositorioPaciente);
            BuscarOrdenConsola.Ejecutar(repositorioOrden);
            BuscarRegistroMedicoConsola.Ejecutar(repositorioRegistro);
            ActualizarPacienteConsola.Ejecutar(repositorioPaciente);
            ActualizarEmpleadoConsola.Ejecutar(repositorioUsuario);
            ActualizarRegistroMedicoConsola.Ejecutar(repositorioRegistro);
        }
    }
}
