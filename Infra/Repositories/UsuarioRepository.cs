using Domain.Interfaces.Repositories;
using Domain.Models;
using Infra.Database;

namespace Infra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly RobotRoom42Context _db;

        public UsuarioRepository(RobotRoom42Context db)
        {
            _db = db;
        }

        public UsuarioModel ObterUsuario(string email, string senha)
        {
            return _db.Usuarios.Where(usuario => usuario.Email == email && usuario.Senha == senha).FirstOrDefault();
        }

        public void SalvarUsuario (UsuarioModel usuario)
        {
            _db.Usuarios.Add(usuario);
            _db.SaveChanges();
        }
    }
}
