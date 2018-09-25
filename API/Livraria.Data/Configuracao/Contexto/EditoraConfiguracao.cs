using Livraria.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Data.Configuracao.Contexto
{
    public class EditoraConfiguracao : IEntityTypeConfiguration<Editora>
    {
        public void Configure(EntityTypeBuilder<Editora> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Versao).IsRowVersion();

            builder.Property(p => p.Nome);

            builder.HasMany(p => p.Livros).WithOne(c => c.Editora);
        }
    }
}
