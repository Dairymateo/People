using System.ComponentModel.DataAnnotations;

namespace TallerConexiònbase.Models
{
    public class RecintoVacunacion
    {
        [Key]
        public int IdRecinto { get; set; }
        [Required]
        public string DireccionRecinto { get; set; }

        public Pais paisRecinto { get; set; }
    }
}
