using Clinica.Application.OutputPorts;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Repositories
{
    public class RepositorioRegistroMedicoEnMemoria : IRepositorioRegistroMedico
    {
        private readonly List<RegistroMedico> _registros = new List<RegistroMedico>();

        public void Guardar(RegistroMedico registro)
        {
            _registros.Add(registro);
        }

        public List<RegistroMedico> ObtenerTodos()
        {
            return _registros;
        }
    }
}
