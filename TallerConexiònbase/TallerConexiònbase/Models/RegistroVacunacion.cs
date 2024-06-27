using System.ComponentModel.DataAnnotations;

namespace TallerConexiònbase.Models
{
    public class RegistroVacunacion
    {
        
        public int Id { get; set; }
        public Estudiante Estudiante { get; set; }
        public Vacuna Vacuna { get; set; }
        public RecintoVacunacion RecintoVacunacion { get; set; }
        public DateTime FechaVacunacion { get; set; }



    }
}
