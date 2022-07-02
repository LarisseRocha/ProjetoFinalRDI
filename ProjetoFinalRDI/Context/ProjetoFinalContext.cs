using Microsoft.EntityFrameworkCore;
using ProjetoFinalRDI.Models;

namespace ProjetoFinalRDI.Context
{
    public class ProjetoFinalContext: DbContext
    {

            public ProjetoFinalContext(DbContextOptions<ProjetoFinalContext> options) : base(options)
            { 
            }
            public virtual DbSet<Aluno> Alunos { get; set; }
            public virtual DbSet<Turma> Turmas { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Aluno>().ToTable("Aluno");

                    modelBuilder.Entity<Aluno>()
                        .HasOne(a => a.Turma)
                        .WithMany(a => a.Aluno)
                        .HasForeignKey(a => a.TurmaId);


                    
                modelBuilder.Entity<Turma>().ToTable("Turma");

                    modelBuilder.Entity<Turma>()
                        .HasMany(a => a.Aluno)
                        .WithOne(a => a.Turma);
            }
 
    }

}

