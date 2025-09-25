using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.InputPorts
{
    public interface IPuertoEntradaPaciente
    {
        bool RegistrarPaciente(Paciente paciente);
        Paciente BuscarPorCedula(string cedula);
    }
}
