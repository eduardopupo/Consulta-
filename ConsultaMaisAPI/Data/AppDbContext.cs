using Microsoft.EntityFrameworkCore;
using ConsultaMaisAPI.Models;

namespace ConsultaMaisAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Dados iniciais para a tabela Pacientes (Documento como int)
            modelBuilder.Entity<Paciente>().HasData(
                new Paciente { Id = 1, Nome = "João Silva", Documento = 12345678901 },
                new Paciente { Id = 2, Nome = "Maria Oliveira", Documento = 98765432100 },
                new Paciente { Id = 3, Nome = "Carlos Pereira", Documento = 11223344556 }
            );

            // Dados iniciais para a tabela Medicos
            modelBuilder.Entity<Medico>().HasData(
                new Medico { Id = 1, Nome = "Dr. Roberto Santos", Especialidade = "Cardiologista" },
                new Medico { Id = 2, Nome = "Dra. Ana Souza", Especialidade = "Dermatologista" },
                new Medico { Id = 3, Nome = "Dr. Luiz Lima", Especialidade = "Neurologista" }
            );

            // Dados iniciais para a tabela Consultas
            modelBuilder.Entity<Consulta>().HasData(
                new Consulta { Id = 1, PacienteId = 1, MedicoId = 1 },
                new Consulta { Id = 2, PacienteId = 2, MedicoId = 2 },
                new Consulta { Id = 3, PacienteId = 3, MedicoId = 3 }
            );
        }
    }
}
