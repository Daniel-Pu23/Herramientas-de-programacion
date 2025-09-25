using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.InputPorts
{
    public interface IPuertoEntradaUsuario
    {
        bool RegistrarUsuario(Usuario usuario);
        Usuario IniciarSesion(string nombreUsuario, string contrasena);
    }
}
