using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clinica.Domain.Validators
{
    public class ValidadorPaciente : IValidadorPaciente
    {
        public bool EsValido(Paciente paciente)
        {
            if (string.IsNullOrWhiteSpace(paciente.NombreCompleto) ||
                string.IsNullOrWhiteSpace(paciente.Cedula))
                return false;

            if (!Regex.IsMatch(paciente.Telefono ?? "", @"^\d{10}$"))
                return false;

            if (!Regex.IsMatch(paciente.CorreoElectronico ?? "", @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return false;

            if (paciente.FechaNacimiento > DateTime.Today)
                return false;

            return true;
        }
    }
}
