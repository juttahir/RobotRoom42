using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class ExoModel
    {
        [Key]
        public int ExoId { get; set; }
        public int ExercicioID { get; set; }
        public decimal Peso { get; set; }
        public string DataExerc { get; set; }
    }
}
