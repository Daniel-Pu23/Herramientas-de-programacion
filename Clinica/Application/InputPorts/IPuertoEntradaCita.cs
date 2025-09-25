using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.InputPorts
{
    public interface IPuertoEntradaCita
    {
        bool ProgramarCita(Cita cita);
        List<Cita> ListarCitas();
    }
}
