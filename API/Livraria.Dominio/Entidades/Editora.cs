using Livraria.Dominio.Entidades.Interfaces;
using System.Collections.Generic;

namespace Livraria.Dominio.Entidades
{
    public class Editora : IIdentificador, IVersionador
    {
        public int Id { get; set; }

        public byte[] Versao { get; set; }

        public string Nome { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}
