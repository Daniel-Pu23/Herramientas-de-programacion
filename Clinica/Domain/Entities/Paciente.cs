using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Paciente : Persona
    {
        public Genero Genero { get; set; }

        public Contacto ContactoEmergencia { get; set; }

        public SeguroMedico Seguro { get; set; }

        public Paciente()
        {
            ContactoEmergencia = new Contacto();
            Seguro = new SeguroMedico();
        }
    }

    public enum Genero
    {
        Masculino,
        Femenino
    }
}
