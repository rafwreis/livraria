using Livraria.Dominio.Interfaces.Repositorios;
using Livraria.Dominio.Interfaces.Servicos;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Livraria.Dominio.Servicos
{
    public class BaseServico<TEntidade> : IBaseServico<TEntidade> where TEntidade : class
    {
        private readonly IBaseRepositorio<TEntidade> baseRepositorio;

        public BaseServico(IBaseRepositorio<TEntidade> baseRepositorio)
        {
            this.baseRepositorio = baseRepositorio;
        }

        public void Alterar(TEntidade entidade)
        {
            baseRepositorio.Alterar(entidade);
        }

        public void Inserir(TEntidade entidade)
        {
            baseRepositorio.Inserir(entidade);
        }

        public IQueryable<TEntidade> Obter(Expression<Func<TEntidade, bool>> expression)
        {
            return baseRepositorio.Obter(expression);
        }

        public IQueryable<TEntidade> Obter()
        {
            return baseRepositorio.Obter();
        }

        public TEntidade Obter(int id)
        {
            return baseRepositorio.Obter(id);
        }

        public void Remover(int id)
        {
            baseRepositorio.Remover(id);
        }

        public void Remover(TEntidade entidade)
        {
            baseRepositorio.Remover(entidade);
        }

        public void Dispose()
        {
            baseRepositorio.Dispose();
        }
    }
}
