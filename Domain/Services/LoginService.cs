using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Domain.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void SalvarUsuario(UsuarioModel usuario)
        {
            _usuarioRepository.SalvarUsuario(usuario);
        }

        public UsuarioModel ObterUsuario(string email, string senha)
        {
            return _usuarioRepository.ObterUsuario(email, senha);
        }
    }
}
