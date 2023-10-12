using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barberia.Shared.Entities
{
    public class Domicilio : Cita
    {
        [Display(Name = "Direccion del Residente")]
        public string Direccion { get; set; }
    }
}
