using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Barberia.Shared.Entities
{
    public class Servicio
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(350, ErrorMessage = "El campo {0} puede tener como maximo {1} caracteres")]
        public string Descripcion { get; set; }//la descripcion del servicio la proporciona una lista
        public float Precio { get; set; }//el precio del servicio lo proporciona una lista

        [JsonIgnore]
        public int CitaId { get; set; }//clave foranea cita
        [JsonIgnore]
        public Cita Cita { get; set; }//una cita
    }
}
