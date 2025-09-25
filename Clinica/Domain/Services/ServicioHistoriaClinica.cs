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
    public class ServicioHistoriaClinica : IPuertoEntradaHistoriaClinica
    {
        private readonly IRepositorioHistoriaClinica _repositorio;

        public ServicioHistoriaClinica(IRepositorioHistoriaClinica repositorio)
        {
            _repositorio = repositorio;
        }

        public bool CrearHistoria(HistoriaClinica historia)
        {
            if (historia == null || historia.Paciente == null || historia.RegistrosMedicos.Count == 0)
                return false;

            _repositorio.Guardar(historia);
            return true;
        }

        public List<HistoriaClinica> ListarHistorias()
        {
            return _repositorio.ObtenerTodas();
        }
    }
}
