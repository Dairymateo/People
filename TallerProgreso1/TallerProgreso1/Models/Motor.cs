using System.ComponentModel.DataAnnotations;

namespace TallerProgreso1.Models
{
    public class Motor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Tipodemotor { get; set; }

        public int caballos { get; set; }

        public int anioFabricacion { get; set; }
    }
}
