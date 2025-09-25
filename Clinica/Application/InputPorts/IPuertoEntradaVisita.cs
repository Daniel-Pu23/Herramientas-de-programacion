using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.InputPorts
{
    public interface IPuertoEntradaVisita
    {
        bool RegistrarVisita(Visita visita);
        List<Visita> ListarVisitas();
    }
}
