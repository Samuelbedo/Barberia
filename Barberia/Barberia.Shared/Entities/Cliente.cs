using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barberia.Shared.Entities
{
    public class Cliente
    {
        [Key]
        [Required]
        public int Cedula { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int Telefono { get; set; }//solo se va a pedir un telefono

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Direccion { get; set; }//solo se va a pedir una direccion

        public Facturacion Facturacion { get; set; }
    }
}
