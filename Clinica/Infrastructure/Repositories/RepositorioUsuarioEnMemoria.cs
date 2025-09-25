using Clinica.Application.OutputPorts;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infrastructure.Repositories
{
    public class RepositorioUsuarioEnMemoria : IRepositorioUsuario
    {
        private readonly List<Usuario> _usuarios = new List<Usuario>();

        public bool Agregar(Usuario usuario)
        {
            if (_usuarios.Any(u => u.Cedula == usuario.Cedula || u.NombreUsuario == usuario.NombreUsuario))
                return false;

            _usuarios.Add(usuario);
            return true;
        }

        public Usuario BuscarPorNombreUsuario(string nombreUsuario)
        {
            return _usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
        }
    }
}
