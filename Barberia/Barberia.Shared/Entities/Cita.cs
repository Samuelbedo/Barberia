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
        public DateOnly Fecha { get; set; }

        [Required(ErrorMessage = "Debe escoger una hora")]
        [Display(Name = "Hora de la cita")]
        public TimeOnly Horario { get; set; }
    }
}
