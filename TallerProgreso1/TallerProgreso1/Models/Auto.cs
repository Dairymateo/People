using System.ComponentModel.DataAnnotations;

namespace TallerProgreso1.Models
{
    public class Auto
    {

        [Key]
        public int Id { get; set; }
        public string Marca { get; set; }

        public int Puertas { get; set; }
        public string color { get; set; }

        public Propietaria propietario { get; set; }


        public int anio { get; set; }
    }
}
