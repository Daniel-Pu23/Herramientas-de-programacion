using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.OutputPorts
{
    public interface IRepositorioPaciente
    {
        bool Agregar(Paciente paciente);
        Paciente BuscarPorCedula(string cedula);
    }
}
