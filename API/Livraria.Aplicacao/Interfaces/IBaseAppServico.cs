using System;
using System.Linq;
using System.Linq.Expressions;

namespace Livraria.Aplicacao.Interfaces
{
    public interface IBaseAppServico<TEntidade> : IDisposable where TEntidade : class
    {
        IQueryable<TEntidade> Obter(Expression<Func<TEntidade, bool>> expression);

        IQueryable<TEntidade> Obter();

        TEntidade Obter(int id);

        void Inserir(TEntidade entidade);

        void Alterar(TEntidade entidade);

        void Remover(int id);

        void Remover(TEntidade entidade);
    }
}
