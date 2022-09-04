using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class AtendimentoModel
    {
        [Key]
        public int AtendimentoId { get; set; }
        public string DescAtt { get; set; }
        public int CodPaciente { get; set; }
        public int CodFisio { get; set; }
    }
}
