using Clinica.Application.InputPorts;
using Clinica.Application.OutputPorts;
using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Services
{
    public class ServicioCita : IPuertoEntradaCita
    {
        private readonly IRepositorioCita _repositorio;

        public ServicioCita(IRepositorioCita repositorio)
        {
            _repositorio = repositorio;
        }

        public bool ProgramarCita(Cita cita)
        {
            if (cita == null || cita.Paciente == null || cita.Profesional == null)
                return false;

            _repositorio.Guardar(cita);
            return true;
        }

        public List<Cita> ListarCitas()
        {
            return _repositorio.ObtenerTodas();
        }
    }
}
