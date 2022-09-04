using System.ComponentModel.DataAnnotations;

namespace Domain.Models

{
    public class UsuarioModel : BaseModel
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Sobrenome { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; } = "Paciente";
    }
}
