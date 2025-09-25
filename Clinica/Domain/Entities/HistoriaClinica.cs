using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Entities
{
    public class HistoriaClinica
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public Paciente Paciente { get; set; }
        public List<RegistroMedico> RegistrosMedicos { get; set; } = new List<RegistroMedico>();
    }
}
