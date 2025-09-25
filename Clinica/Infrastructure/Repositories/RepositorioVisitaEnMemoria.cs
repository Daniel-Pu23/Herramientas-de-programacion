using Clinica.Application.OutputPorts;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Repositories
{
    public class RepositorioVisitaEnMemoria : IRepositorioVisita
    {
        private readonly List<Visita> _visitas = new List<Visita>();

        public void Guardar(Visita visita)
        {
            _visitas.Add(visita);
        }

        public List<Visita> ObtenerTodas()
        {
            return _visitas;
        }
    }
}
