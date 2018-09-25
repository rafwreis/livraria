using Livraria.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Data.Configuracao.Contexto
{
    public class AutorConfiguracao : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Versao).IsRowVersion();

            builder.Property(p => p.Nome);

            builder.HasMany(p => p.Livros).WithOne(c => c.Autor);
        }
    }
}
