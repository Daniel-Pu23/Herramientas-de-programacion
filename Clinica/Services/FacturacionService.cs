using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Services
{
    public class FacturacionService
    {
        private List<Facturacion> facturas;

        public FacturacionService()
        {
            facturas = new List<Facturacion>();
        }

        public bool CrearFactura(Facturacion nueva)
        {
            if (nueva.Paciente == null || nueva.Medico == null || nueva.Ordenes == null || nueva.Ordenes.Count == 0)
                return false;

            nueva.TotalBruto = nueva.Ordenes.Sum(o => o.Items.Sum(i => i.Costo));

            nueva.Copago = nueva.Paciente.TieneSeguroActivo() ? nueva.TotalBruto * 0.1M : nueva.TotalBruto;

            facturas.Add(nueva);
            return true;
        }

        public List<Facturacion> ObtenerFacturasPaciente(string cedula)
        {
            return facturas.Where(f => f.Paciente.Cedula == cedula).ToList();
        }

        public List<Facturacion> ObtenerTodas()
        {
            return facturas;
        }
    }
}
