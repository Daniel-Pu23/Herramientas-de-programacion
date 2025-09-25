using Clinica.Application.OutputPorts;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Repositories
{
    public class RepositorioPacienteEnMemoria : IRepositorioPaciente
    {
        private readonly List<Paciente> _pacientes = new List<Paciente>();

        public bool Agregar(Paciente paciente)
        {
            if (_pacientes.Any(p => p.Cedula == paciente.Cedula))
                return false;

            _pacientes.Add(paciente);
            return true;
        }

        public Paciente BuscarPorCedula(string cedula)
        {
            return _pacientes.FirstOrDefault(p => p.Cedula == cedula);
        }
    }
}
