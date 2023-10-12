using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barberia.Shared.Entities
{
    public class Cita
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe escoger una fecha")]
        [Display(Name = "Dia de la cita")]
        public string Fecha { get; set; }

        [Required(ErrorMessage = "Debe escoger una hora")]
        [Display(Name = "Hora de la cita")]
        public string Horario { get; set; }

        [Display (Name = "Cita")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Tipo { get; set; }//referencia si la cita va a ser a domicilio o en el local
    }
}
