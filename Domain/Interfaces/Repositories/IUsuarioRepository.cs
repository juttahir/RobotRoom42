using Domain.Models;

namespace Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        UsuarioModel ObterUsuario(string email, string senha);

        void SalvarUsuario(UsuarioModel usuario);

    }
}
