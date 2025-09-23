using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Representa una visita del paciente atendido por una enfermera.
    /// </summary>
    
    public class Visita
    {
        /// <summary>
        /// Identificador unico de la visita
        /// </summary>
        
        public Guid Id { get; set; }

        /// <summary>
        /// Paciente al que se le realiza la visita
        /// </summary>
        
        public Paciente Paciente { get; set; }

        /// <summary>
        /// Enfermera que atiende la visita
        /// </summary>

        public Usuario Enfermera { get; set; }

        /// <summary>
        /// Fecha y hora de la visita.
        /// </summary>
        
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Datos vitales del paciente registrados durante la visita.
        /// </summary>
        
        public DatosVitales DatosVitales { get; set; }

        /// <summary>
        /// Lista de medicamentos administrados durante la visita.
        /// </summary>
        
        public List<Medicamento> MedicamentosAplicados { get; set; }

        /// <summary>
        /// Lista de procedimientos realizados durante la visita.
        /// </summary>
        
        public List<Procedimiento> ProcedimientosRealizados { get; set; }

        /// <summary>
        /// Observaciones adicionales de la enfermera.
        /// </summary>
        
        public string Observaciones { get; set; }

        /// <summary>
        /// Constructor que inicializa listas y campos necesarios.
        /// </summary>
        
        public Visita()
        {
            Id = Guid.NewGuid();
            MedicamentosAplicados = new List<Medicamento>();
            ProcedimientosRealizados = new List<Procedimiento>();
            DatosVitales = new DatosVitales();
            Fecha = DateTime.Now;
        }
    }
}
