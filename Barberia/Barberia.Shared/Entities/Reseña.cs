using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Barberia.Shared.Entities
{
    public class Reseña
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(350, ErrorMessage = "El campo {0} puede tener como maximo {1} caracteres")]
        public string Comentario { get; set; }

        [Display(Name = "Numero de estrellas")]
        [Required(ErrorMessage = "La calificacion es obligatoria")]
        public string Calificacion { get; set; }

        [JsonIgnore]
        public ICollection<BarberoReseña> BarberoReseña { get; set; }
    }
}
