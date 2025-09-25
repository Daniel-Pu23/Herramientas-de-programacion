using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.OutputPorts
{
    public interface IRepositorioFactura
    {
        void Guardar(Factura factura);
        List<Factura> ObtenerTodas();
    }
}
