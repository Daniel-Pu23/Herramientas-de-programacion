using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Services
{
    public class CitaService
    {
        private List<Cita> citas;

        public CitaService()
        {
            citas = new List<Cita>();
        }

        public bool CrearCita(Cita nueva)
        {
            if (nueva.Paciente == null || nueva.Profesional == null || nueva.FechaHora < DateTime.Now)
                return false;

            bool conflicto = citas.Any(c =>
                c.Profesional.Cedula == nueva.Profesional.Cedula &&
                Math.Abs((c.FechaHora - nueva.FechaHora).TotalMinutes) < 30);

            if (conflicto) return false;

            citas.Add(nueva);
            return true;
        }

        public List<Cita> ObtenerPorPaciente(string cedula)
        {
            return citas.Where(c => c.Paciente.Cedula == cedula).ToList();
        }

        public List<Cita> ObtenerPorProfesional(string cedula)
        {
            return citas.Where(c => c.Profesional.Cedula == cedula).ToList();
        }

        public List<Cita> ObtenerTodas()
        {
            return citas;
        }
    }
}
