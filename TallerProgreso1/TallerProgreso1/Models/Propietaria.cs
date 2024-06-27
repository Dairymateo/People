using System.ComponentModel.DataAnnotations;

namespace TallerProgreso1.Models
{
    public class Propietaria
    {
        [Key]
        public int propietarioId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimeinto { get; set; }

        public Boolean Ecuatoriano { get; set; }

    }
}
