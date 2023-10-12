using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barberia.Shared.Entities
{
    public class Local : Cita
    {
        [Display(Name = "Direccion del Local")]
        public string Direccion { get; set; }

        [Display(Name = "Capacidad del Local")]
        public int Capacidad { get; set; }
    }
}
