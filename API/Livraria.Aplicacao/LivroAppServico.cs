using Livraria.Aplicacao.Interfaces;
using Livraria.Dominio.Entidades;
using Livraria.Dominio.Interfaces.Servicos;

namespace Livraria.Aplicacao
{
    public class LivroAppServico : BaseAppServico<Livro>, ILivroAppServico
    {
        public LivroAppServico(ILivroServico livroServico)
            :base(livroServico)
        {

        }
    }
}
