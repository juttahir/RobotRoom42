using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class FisioModel : BaseModel
    {
        [Key]
        public int FisioId { get; set; }
    }
}
