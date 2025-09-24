using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Services
{
    public class RegistroMedicoService
    {
        private List<RegistroMedico> registros;

        public RegistroMedicoService()
        {
            registros = new List<RegistroMedico>();
        }

        public bool CrearRegistro(RegistroMedico nuevo)
        {
            if (nuevo.Paciente == null || nuevo.Medico == null || string.IsNullOrWhiteSpace(nuevo.Diagnostico))
                return false;

            registros.Add(nuevo);
            return true;
        }

        public bool ActualizarRegistro(Guid id, string nuevoDiagnostico)
        {
            var registro = registros.FirstOrDefault(r => r.Id == id);
            if (registro == null) return false;

            registro.Diagnostico = nuevoDiagnostico;
            return true;
        }

        public List<RegistroMedico> BuscarPorPaciente(string cedula)
        {
            return registros.Where(r => r.Paciente.Cedula == cedula).ToList();
        }

        public List<RegistroMedico> ObtenerTodos()
        {
            return registros;
        }
    }
}
