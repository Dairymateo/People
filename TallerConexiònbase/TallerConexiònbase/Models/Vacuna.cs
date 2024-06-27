using System.ComponentModel.DataAnnotations;

namespace TallerConexiònbase.Models
{
    public class Vacuna
    {
        [Key]
        public int Id { get; set; }
        public string NombreVacuna { get; set; }
        public Pais Pais { get; set; }
    }
}
