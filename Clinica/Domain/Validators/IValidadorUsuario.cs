using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Validators
{
    public interface IValidadorUsuario
    {
        bool EsValido(Usuario usuario);
    }
}
