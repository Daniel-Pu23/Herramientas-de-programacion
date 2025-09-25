using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.InputPorts
{
    public interface IPuertoEntradaFactura
    {
        bool CrearFactura(Factura factura);
        List<Factura> ListarFacturas();
    }
}
