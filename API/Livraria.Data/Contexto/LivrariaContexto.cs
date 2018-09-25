using Livraria.Data.Configuracao.Contexto;
using Livraria.Dominio.Entidades;
using Livraria.Dominio.Interfaces.Infraestrutura;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Data.Contexto
{
    public class LivrariaContexto : DbContext, IContexto
    {
        public DbSet<Livro> Livro { get; set; }

        public DbSet<Autor> Autor { get; set; }

        public DbSet<Editora> Editora { get; set; }

        public LivrariaContexto(DbContextOptions<LivrariaContexto> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LivroConfiguracao());
            modelBuilder.ApplyConfiguration(new AutorConfiguracao());
            modelBuilder.ApplyConfiguration(new EditoraConfiguracao());
        }
    }
}
