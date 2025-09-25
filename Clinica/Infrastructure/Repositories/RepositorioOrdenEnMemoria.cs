using Clinica.Application.OutputPorts;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Repositories
{
    public class RepositorioOrdenEnMemoria : IRepositorioOrden
    {
        private readonly List<Orden> _ordenes = new List<Orden>();

        public void Guardar(Orden orden)
        {
            _ordenes.Add(orden);
        }

        public List<Orden> ObtenerTodas()
        {
            return _ordenes;
        }
    }
}
