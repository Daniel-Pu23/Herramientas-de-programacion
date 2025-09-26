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

            // Usuarios
            var repositorioUsuarios = new RepositorioUsuarioEnMemoria();
            var validadorUsuario = new ValidadorUsuario();
            IPuertoEntradaUsuario servicioUsuario = new ServicioUsuario(repositorioUsuarios, validadorUsuario);
            SimuladorUsuarioConsola.Ejecutar(servicioUsuario);

            // Pacientes
            var repositorioPaciente = new RepositorioPacienteEnMemoria();
            var validadorPaciente = new ValidadorPaciente();
            IPuertoEntradaPaciente servicioPaciente = new ServicioPaciente(repositorioPaciente, validadorPaciente);
            SimuladorPacienteConsola.Ejecutar(servicioPaciente);

            // Orden médica
            var repositorioOrden = new RepositorioOrdenEnMemoria();
            var validadorOrden = new ValidadorOrden();
            IPuertoEntradaOrden servicioOrden = new ServicioOrden(repositorioOrden, validadorOrden);
            SimuladorOrdenConsola.Ejecutar(servicioOrden);

            // Factura
            var repositorioFactura = new RepositorioFacturaEnMemoria();
            IPuertoEntradaFactura servicioFactura = new ServicioFactura(repositorioFactura);
            SimuladorFacturaConsola.Ejecutar(servicioFactura);

            // Visita
            var repositorioVisita = new RepositorioVisitaEnMemoria();
            IPuertoEntradaVisita servicioVisita = new ServicioVisita(repositorioVisita);
            SimuladorVisitaConsola.Ejecutar(servicioVisita);

            // Registro médico
            var repositorioRegistro = new RepositorioRegistroMedicoEnMemoria();
            IPuertoEntradaRegistroMedico servicioRegistro = new ServicioRegistroMedico(repositorioRegistro);
            SimuladorRegistroMedicoConsola.Ejecutar(servicioRegistro);

            // Historia clínica
            var repositorioHistoria = new RepositorioHistoriaClinicaEnMemoria();
            IPuertoEntradaHistoriaClinica servicioHistoria = new ServicioHistoriaClinica(repositorioHistoria);
            SimuladorHistoriaClinicaConsola.Ejecutar(servicioHistoria);

            // Consultas
            BuscarPacienteConsola.Ejecutar(repositorioPaciente);
            BuscarOrdenConsola.Ejecutar(repositorioOrden);
            BuscarRegistroMedicoConsola.Ejecutar(repositorioRegistro);

            // Actualizaciones
            ActualizarEmpleadoConsola.Ejecutar(repositorioUsuarios);
            ActualizarPacienteConsola.Ejecutar(repositorioPaciente);
            ActualizarRegistroMedicoConsola.Ejecutar(repositorioRegistro);

            Console.WriteLine("\n✅ TODO FUNCIONÓ CORRECTAMENTE ✅");
        }
    }
}

