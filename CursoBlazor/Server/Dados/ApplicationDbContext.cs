using CursoBlazor.Shared.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoBlazor.Server.Dados
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CategoriaFilme> CategoriaFilmes { get; set; }
        public DbSet<FilmePessoa> FilmePessoas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Filme> Filmes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaFilme>().HasKey(x => new { x.CategoriaId, x.FilmeId });
            modelBuilder.Entity<FilmePessoa>().HasKey(x => new { x.FilmeId, x.PessoaId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
