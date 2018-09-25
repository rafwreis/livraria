using Livraria.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Data.Configuracao.Contexto
{
    public class LivroConfiguracao : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Versao).IsRowVersion();

            builder.Property(p => p.Titulo);

            builder.HasOne(p => p.Editora).WithMany(c => c.Livros);

            builder.HasOne(p => p.Autor).WithMany(c => c.Livros);
        }
    }
}
