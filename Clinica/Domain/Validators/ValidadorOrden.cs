using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Validators
{
    public class ValidadorOrden : IValidadorOrden
    {
        public bool EsOrdenValida(Orden orden)
        {
            var tipoBase = orden.Items.FirstOrDefault()?.GetType();
            return orden.Items.All(i => i.GetType() == tipoBase);
        }
    }
}
