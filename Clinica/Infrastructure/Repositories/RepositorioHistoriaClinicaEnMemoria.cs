using Clinica.Application.OutputPorts;
using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Repositories
{
    public class RepositorioHistoriaClinicaEnMemoria : IRepositorioHistoriaClinica
    {
        private readonly List<HistoriaClinica> _historias = new List<HistoriaClinica>();

        public void Guardar(HistoriaClinica historia)
        {
            _historias.Add(historia);
        }

        public List<HistoriaClinica> ObtenerTodas()
        {
            return _historias;
        }
    }
}
