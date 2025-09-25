using Clinica.Application.InputPorts;
using Clinica.Application.OutputPorts;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Services
{
    public class ServicioRegistroMedico : IPuertoEntradaRegistroMedico
    {
        private readonly IRepositorioRegistroMedico _repositorio;

        public ServicioRegistroMedico(IRepositorioRegistroMedico repositorio)
        {
            _repositorio = repositorio;
        }

        public bool CrearRegistro(RegistroMedico registro)
        {
            if (registro == null || registro.Paciente == null || registro.Profesional == null)
                return false;

            _repositorio.Guardar(registro);
            return true;
        }

        public List<RegistroMedico> ListarRegistros()
        {
            return _repositorio.ObtenerTodos();
        }
    }
}
