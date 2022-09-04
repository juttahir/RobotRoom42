using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class AnguloModel
    {
        [Key]
        public int AnguloId { get; set; }
        public int ExercID { get; set; }
        public string TimeSprint { get; set; }
        public int Serie { get; set; }
        public decimal Angulo { get; set; }
    }
}
