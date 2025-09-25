using Clinica.Application.OutputPorts;
using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Repositories
{
    public class RepositorioCitaEnMemoria : IRepositorioCita
    {
        private readonly List<Cita> _citas = new List<Cita>();

        public void Guardar(Cita cita)
        {
            _citas.Add(cita);
        }

        public List<Cita> ObtenerTodas()
        {
            return _citas;
        }
    }
}
