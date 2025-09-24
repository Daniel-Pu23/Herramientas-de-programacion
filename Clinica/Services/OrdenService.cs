using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Services
{
    public class OrdenService
    {
        private List<Orden> ordenes;

        public OrdenService()
        {
            ordenes = new List<Orden>();
        }

        public bool RegistrarOrden(Orden nueva)
        {
            if (nueva.Items.Count == 0 || !nueva.EsOrdenValida())
                return false;

            if (ordenes.Any(o => o.NumeroOrden == nueva.NumeroOrden))
                return false;

            ordenes.Add(nueva);
            return true;
        }

        public Orden BuscarPorNumero(int numero)
        {
            return ordenes.FirstOrDefault(o => o.NumeroOrden == numero);
        }

        public List<Orden> ObtenerPorPaciente(string cedulaPaciente)
        {
            return ordenes.Where(o => o.CedulaPaciente == cedulaPaciente).ToList();
        }
    }
}
