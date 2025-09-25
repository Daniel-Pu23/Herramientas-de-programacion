using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.InputPorts
{
    public interface IPuertoEntradaRegistroMedico
    {
        bool CrearRegistro(RegistroMedico registro);
        List<RegistroMedico> ListarRegistros();
    }
}
