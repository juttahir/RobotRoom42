using Domain.Models;

namespace Domain.Interfaces.Services
{
    public interface ILoginService
    {
        void SalvarUsuario(UsuarioModel usuario);

        UsuarioModel ObterUsuario(string email, string senha);
    }
}
