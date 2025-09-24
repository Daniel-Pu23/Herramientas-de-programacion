using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Services
{
    public class VisitaService
    {
        private List<Visita> visitas;

        public VisitaService()
        {
            visitas = new List<Visita>();
        }

        public bool CrearVisita(Visita nueva)
        {
            if (nueva.Paciente == null || nueva.Enfermera == null || nueva.DatosVitales == null)
                return false;

            visitas.Add(nueva);
            return true;
        }

        public List<Visita> ObtenerPorPaciente(string cedula)
        {
            return visitas.Where(v => v.Paciente.Cedula == cedula).ToList();
        }

        public List<Visita> ObtenerTodas()
        {
            return visitas;
        }
    }
}
