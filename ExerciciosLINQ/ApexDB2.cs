namespace ExerciciosLINQ
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApexDB2 : DbContext
    {
        public ApexDB2()
            : base("name=ApexDB2")
        {
        }

        public virtual DbSet<ALUNO> ALUNO { get; set; }
        public virtual DbSet<CERTIFICADO> CERTIFICADO { get; set; }
        public virtual DbSet<CURSO> CURSO { get; set; }
        public virtual DbSet<CURSO_ALUNO> CURSO_ALUNO { get; set; }
        public virtual DbSet<PESSOA> PESSOA { get; set; }
        public virtual DbSet<PROFESSOR> PROFESSOR { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ALUNO>()
                .Property(e => e.cargo)
                .IsUnicode(false);

            modelBuilder.Entity<ALUNO>()
                .HasMany(e => e.CURSO_ALUNO)
                .WithRequired(e => e.ALUNO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.nomeCurso)
                .IsUnicode(false);

            modelBuilder.Entity<CURSO>()
                .HasMany(e => e.CURSO_ALUNO)
                .WithRequired(e => e.CURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.nomePessoa)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.endereco)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.ALUNO)
                .WithRequired(e => e.PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.PROFESSOR)
                .WithRequired(e => e.PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROFESSOR>()
                .HasMany(e => e.CURSO)
                .WithRequired(e => e.PROFESSOR)
                .WillCascadeOnDelete(false);
        }
    }
}
