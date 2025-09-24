using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios;

        public UsuarioService()
        {
            usuarios = new List<Usuario>();
        }

        public bool RegistrarUsuario(Usuario nuevo)
        {
            if (!nuevo.NombreUsuarioValido() || !nuevo.ContrasenaValida())
                return false;

            if (usuarios.Any(u => u.NombreUsuario == nuevo.NombreUsuario))
                return false; // Usuario ya existe

            usuarios.Add(nuevo);
            return true;
        }

        public Usuario Login(string nombreUsuario, string contrasena)
        {
            return usuarios.FirstOrDefault(u =>
                u.NombreUsuario == nombreUsuario &&
                u.Contrasena == contrasena);
        }

        public List<Usuario> ObtenerTodos()
        {
            return usuarios;
        }
    }
}
