using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clinica.Models
{
    /// <summary>
    /// Representa la poliza de seguro medico de un paciente.
    /// </summary>
    
    public class SeguroMedico
    {
        /// <summary>
        /// Nombre de la compañia aseguradora.
        /// </summary>
        
        public string NombreCompania { get; set; }

        /// <summary>
        /// Numero unico de la poliza
        /// </summary>
        
        public string NumeroPoliza { get; set; }

        /// <summary>
        /// Indica si la poliza esta activa (true) o inactiva (false).
        /// </summary>
        
        public bool Activa {  get; set; }

        /// <summary>
        /// Fecha en la que finaliza la vigencia de la poliza.
        /// </summary>
        
        public DateTime VigenteHasta { get; set; }

        /// <summary>
        /// Verifica si la poliza esta activa actualmente.
        /// </summary>
        
        public bool EstaActiva()
        {
            return Activa && DateTime.Today <= VigenteHasta;
        }

        /// <summary>
        /// Calcula los dias restantes de cobertura.
        /// </summary>
        
        public int DiasRestantes()
        {
            if (!Activa || DateTime.Today > VigenteHasta)
                return 0;

            return (VigenteHasta - DateTime.Today).Days;
        }
    }
}
