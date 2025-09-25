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
    public class ServicioFactura : IPuertoEntradaFactura
    {
        private readonly IRepositorioFactura _repositorio;

        public ServicioFactura(IRepositorioFactura repositorio)
        {
            _repositorio = repositorio;
        }

        public bool CrearFactura(Factura factura)
        {
            if (factura == null || factura.Paciente == null || factura.ValorTotal <= 0)
                return false;

            factura.ValorCopago = factura.ValorTotal * 0.10m;
            _repositorio.Guardar(factura);
            return true;
        }

        public List<Factura> ListarFacturas()
        {
            return _repositorio.ObtenerTodas();
        }
    }
}
