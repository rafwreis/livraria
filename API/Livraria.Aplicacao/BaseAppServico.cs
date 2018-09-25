using Livraria.Aplicacao.Interfaces;
using Livraria.Dominio.Interfaces.Servicos;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Livraria.Aplicacao
{
    public class BaseAppServico<TEntidade> : IBaseAppServico<TEntidade> where TEntidade : class
    {
        private readonly IBaseServico<TEntidade> baseServico;

        public BaseAppServico(IBaseServico<TEntidade> baseServico)
        {
            this.baseServico = baseServico;
        }

        public void Alterar(TEntidade entidade)
        {
            baseServico.Alterar(entidade);
        }

        public void Inserir(TEntidade entidade)
        {
            baseServico.Inserir(entidade);
        }

        public IQueryable<TEntidade> Obter(Expression<Func<TEntidade, bool>> expression)
        {
            return baseServico.Obter(expression);
        }

        public IQueryable<TEntidade> Obter()
        {
            return baseServico.Obter();
        }

        public TEntidade Obter(int id)
        {
            return baseServico.Obter(id);
        }

        public void Remover(int id)
        {
            baseServico.Remover(id);
        }

        public void Remover(TEntidade entidade)
        {
            baseServico.Remover(entidade);
        }

        public void Dispose()
        {
            baseServico.Dispose();
        }
    }
}
