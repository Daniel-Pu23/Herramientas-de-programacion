using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.OutputPorts
{
    public interface IRepositorioHistoriaClinica
    {
        void Guardar(HistoriaClinica historia);
        List<HistoriaClinica> ObtenerTodas();
    }
}
