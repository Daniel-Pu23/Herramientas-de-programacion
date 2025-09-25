using Clinica.Application.InputPorts;
using Clinica.Application.OutputPorts;
using Clinica.Domain.Validators;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Services
{
    public class ServicioPaciente : IPuertoEntradaPaciente
    {
        private readonly IRepositorioPaciente _repositorio;
        private readonly IValidadorPaciente _validador;

        public ServicioPaciente(IRepositorioPaciente repositorio, IValidadorPaciente validador)
        {
            _repositorio = repositorio;
            _validador = validador;
        }

        public bool RegistrarPaciente(Paciente paciente)
        {
            if (!_validador.EsValido(paciente)) return false;
            return _repositorio.Agregar(paciente);
        }

        public Paciente BuscarPorCedula(string cedula)
        {
            return _repositorio.BuscarPorCedula(cedula);
        }
    }

}
