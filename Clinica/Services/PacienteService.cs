using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Services
{
    public class PacienteService
    {
        private List<Paciente> pacientes;

        public PacienteService()
        {
            pacientes = new List<Paciente>();
        }

        public bool RegistrarPaciente(Paciente nuevo)
        {
            if (pacientes.Any(p => p.Cedula == nuevo.Cedula))
                return false; // Ya existe

            pacientes.Add(nuevo);
            return true;
        }

        public Paciente BuscarPorCedula(string cedula)
        {
            return pacientes.FirstOrDefault(p => p.Cedula == cedula);
        }

        public bool ActualizarDatos(string cedula, Paciente actualizado)
        {
            var existente = BuscarPorCedula(cedula);
            if (existente == null) return false;

            existente.NombreCompleto = actualizado.NombreCompleto;
            existente.Telefono = actualizado.Telefono;
            existente.Direccion = actualizado.Direccion;
            existente.CorreoElectronico = actualizado.CorreoElectronico;
            existente.ContactoEmergencia = actualizado.ContactoEmergencia;
            existente.Seguro = actualizado.Seguro;
            return true;
        }

        public List<Paciente> ObtenerTodos()
        {
            return pacientes;
        }
    }
}
