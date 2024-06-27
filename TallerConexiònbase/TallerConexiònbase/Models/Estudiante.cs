using System.ComponentModel.DataAnnotations;

namespace TallerConexiònbase.Models
{
    public class Estudiante
    {
        [Key]
        public String BannerId { get; set; }
        public String Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<RegistroVacunacion> registroVacunacions { get; set; }
    }
}
