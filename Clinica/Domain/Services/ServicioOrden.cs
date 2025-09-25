using Clinica.Application.InputPorts;
using Clinica.Application.OutputPorts;
using Clinica.Domain.Validators;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Services
{
    public class ServicioOrden : IPuertoEntradaOrden
    {
        private readonly IRepositorioOrden _repositorio;
        private readonly IValidadorOrden _validador;

        public ServicioOrden(IRepositorioOrden repositorio, IValidadorOrden validador)
        {
            _repositorio = repositorio;
            _validador = validador;
        }

        public bool CrearOrden(Orden orden)
        {
            if (!_validador.EsOrdenValida(orden)) return false;
            _repositorio.Guardar(orden);
            return true;
        }

        public List<Orden> ListarOrdenes()
        {
            return _repositorio.ObtenerTodas();
        }
    }
}
