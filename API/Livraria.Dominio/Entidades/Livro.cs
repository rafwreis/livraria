using Livraria.Dominio.Entidades.Interfaces;
using System.Collections.Generic;

namespace Livraria.Dominio.Entidades
{
    public class Livro : IIdentificador, IVersionador
    {
        public int Id { get; set; }

        public byte[] Versao { get; set; }

        public string Titulo { get; set; }

        public virtual Autor Autor { get; set; }

        public virtual Editora Editora { get; set; }
    }
}
