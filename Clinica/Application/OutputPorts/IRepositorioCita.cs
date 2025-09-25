using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.OutputPorts
{
    public interface IRepositorioCita
    {
        void Guardar(Cita cita);
        List<Cita> ObtenerTodas();
    }
}
