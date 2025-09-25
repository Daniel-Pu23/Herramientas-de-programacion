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
    public class ServicioUsuario : IPuertoEntradaUsuario
    {
        private readonly IRepositorioUsuario _repositorio;
        private readonly IValidadorUsuario _validador;

        public ServicioUsuario(IRepositorioUsuario repositorio, IValidadorUsuario validador)
        {
            _repositorio = repositorio;
            _validador = validador;
        }

        public bool RegistrarUsuario(Usuario usuario)
        {
            if (!_validador.EsValido(usuario)) return false;
            return _repositorio.Agregar(usuario);
        }

        public Usuario IniciarSesion(string nombreUsuario, string contrasena)
        {
            var usuario = _repositorio.BuscarPorNombreUsuario(nombreUsuario);
            if (usuario == null) return null;
            return usuario.Contrasena == contrasena ? usuario : null;
        }
    }
}
