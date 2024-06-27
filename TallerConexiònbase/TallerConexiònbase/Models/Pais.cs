using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TallerConexiònbase.Models
{
    public class Pais
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string Nombre { get; set; }
        [AllowNull]
        public int CodigoTelefonico { get; set; }
    }
}
