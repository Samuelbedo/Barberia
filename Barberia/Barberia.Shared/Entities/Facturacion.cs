using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barberia.Shared.Entities
{
    public class Facturacion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        [Display(Name = "Total")]
        public decimal Monto { get; set; }

        [Display (Name = "Forma de pago")]
        [Required(ErrorMessage = "Debe seleccionar una Forma de pago")]
        public string MetodoPago { get; set; }
    }
}
