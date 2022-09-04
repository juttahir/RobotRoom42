using Domain.Models;
using Infra.Database;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Tests.Respositories
{
    public class UsuarioRepositoryTest
    {
        [Fact]
        public void ObterUsuario_WithEmailAndSenha_ReturnsUsuario()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<RobotRoom42Context>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var dbContext = new RobotRoom42Context(options);

            var user = new UsuarioModel()
            {
                Login = "Pipoca",
                Nome = "Pipoca",
                Sobrenome = "Azulão",
                Tipo = "Não Binario",
                Email = "pipoca@gmail.com",
                Senha = "batatacomiolos"
            };
            dbContext.Usuarios.Add(user);
            dbContext.SaveChanges();

            var repo = new UsuarioRepository(dbContext);

            // Act
            var result = repo.ObterUsuario("pipoca@gmail.com", "batatacomiolos");

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expected:"Pipoca", actual:result.Nome);
            Assert.Equal("Pipoca", result.Login);
            Assert.Equal("xablau", result.Sobrenome);
        }
    }
}
