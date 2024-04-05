using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Models;
using System.Data.Common;

namespace SmartSchool.WebAPI.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplina>().HasKey(AD => new { AD.AlunoId, AD.DisciplinaId });
        }
    }
}
