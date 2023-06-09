using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class FilmesContext : DbContext
    {
        public FilmesContext(DbContextOptions options) : base(options) { }

        public FilmesContext() { }

        public virtual DbSet<Filme> Filmes { get; set; }

        public virtual DbSet<Diretor> Diretor { get; set; }

        public virtual DbSet<FilmeDiretor> FilmeDiretor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("ServerConnection");
            }
        }

    }
}
