using Livraria.Dominio.Entidades;
using Livraria.Dominio.Interfaces.Repositorios;
using Livraria.Dominio.Interfaces.Servicos;

namespace Livraria.Dominio.Servicos
{
    public class LivroServico : BaseServico<Livro>, ILivroServico
    {
        public LivroServico(ILivroRepositorio livroRepositorio)
            :base(livroRepositorio)
        {
        }
    }
}
