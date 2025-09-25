using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.InputPorts
{
    public interface IPuertoEntradaOrden
    {
        bool CrearOrden(Orden orden);
        List<Orden> ListarOrdenes();
    }
}
