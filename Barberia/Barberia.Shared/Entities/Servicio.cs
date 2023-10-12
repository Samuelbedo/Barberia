using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barberia.Shared.Entities
{
    public class Servicio
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(350, ErrorMessage = "El campo {0} puede tener como maximo {1} caracteres")]
        public string Descripcion { get; set; }
        public float Precio { get; set; }
    }
}
