using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Barberia.Shared.Entities
{
    public class BarberoReseña
    {
        public int Id { get; set; }
        //Barbero
        [JsonIgnore]
        public Barbero Barbero { get; set; }
        [JsonIgnore]
        public int BarberoCedula { get; set; }

        //Reseña
        [JsonIgnore]
        public Reseña Reseña { get; set; }
        [JsonIgnore]
        public int ReseñaId { get; set; }
    }
}
