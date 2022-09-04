using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infra.Database
{
    public class RobotRoom42Context : DbContext
    {
        public DbSet<AnguloModel> Angulos { get; set; }
        public DbSet<AtendimentoModel> Atendimentos { get; set; }
        public DbSet<ExoModel> Exos { get; set; }
        public DbSet<FisioModel> Fisios { get; set; }
        public DbSet<PacienteModel> Pacientes { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        
        public RobotRoom42Context(DbContextOptions<RobotRoom42Context> options) : base(options)
        {

        }
    }
}
