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
    public class ServicioVisita : IPuertoEntradaVisita
    {
        private readonly IRepositorioVisita _repositorio;

        public ServicioVisita(IRepositorioVisita repositorio)
        {
            _repositorio = repositorio;
        }

        public bool RegistrarVisita(Visita visita)
        {
            if (visita == null || visita.Paciente == null || visita.Profesional == null)
                return false;

            _repositorio.Guardar(visita);
            return true;
        }

        public List<Visita> ListarVisitas()
        {
            return _repositorio.ObtenerTodas();
        }
    }
}
