using Clinica.Application.OutputPorts;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Repositories
{
    public class RepositorioFacturaEnMemoria : IRepositorioFactura
    {
        private readonly List<Factura> _facturas = new List<Factura>();

        public void Guardar(Factura factura)
        {
            _facturas.Add(factura);
        }

        public List<Factura> ObtenerTodas()
        {
            return _facturas;
        }
    }
}
