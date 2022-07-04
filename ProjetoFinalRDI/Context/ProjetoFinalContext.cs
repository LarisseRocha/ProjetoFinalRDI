using Microsoft.EntityFrameworkCore;
using ProjetoFinalRDI.Models;

namespace ProjetoFinalRDI.Context
{
    public class ProjetoFinalContext: DbContext
    {

            public ProjetoFinalContext(DbContextOptions<ProjetoFinalContext> options) : base(options)
            { 
                
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            {
                if (!optionBuilder.IsConfigured)
                {

                    IConfigurationRoot configuration = new ConfigurationBuilder()
                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                        .AddJsonFile("appsettings.json")
                        .Build();

                optionBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

                }

            }

            public virtual DbSet<Aluno> Alunos { get; set; }
            public virtual DbSet<Turma> Turmas { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Aluno>().ToTable("Alunos");

                    modelBuilder.Entity<Aluno>()
                        .HasOne(a => a.Turma)
                        .WithMany(a => a.Aluno)
                        .HasForeignKey(a => a.TurmaId);


                    
                modelBuilder.Entity<Turma>().ToTable("Turmas");

                    modelBuilder.Entity<Turma>()
                        .HasMany(a => a.Aluno)
                        .WithOne(a => a.Turma);
            }
 
    }

}

