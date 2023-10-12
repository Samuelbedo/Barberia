﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barberia.Shared.Entities
{
    public class Barbero
    {
        [Key]
        [Required]
        public int Cedula { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int Telefono { get; set; }//el telefono solo es laboral, entonces un barbero solo tiene un telefono

        public string Especialidad { get; set; }
    }
}