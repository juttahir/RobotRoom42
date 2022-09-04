using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class PacienteModel : BaseModel
    {
        [Key]
        public int PacienteId { get; set; }
        public decimal Estatura { get; set; }
        public int CodExo { get; set; }
    }
}
