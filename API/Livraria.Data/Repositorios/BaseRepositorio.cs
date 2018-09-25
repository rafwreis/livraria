using Livraria.Dominio.Entidades.Interfaces;
using Livraria.Dominio.Interfaces.Repositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Livraria.Data.Repositorios
{
    public class BaseRepositorio<TEntidade> : IBaseRepositorio<TEntidade>, IDisposable where TEntidade : class, IIdentificador
    {
        protected DbContext contexto;
        protected DbSet<TEntidade> dbSet;

        public BaseRepositorio(DbContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<TEntidade>();
        }

        public IQueryable<TEntidade> Obter(Expression<Func<TEntidade, bool>> expression)
        {
            return dbSet.Include(expression);
        }

        public IQueryable<TEntidade> Obter()
        {
            return dbSet;
        }

        public TEntidade Obter(int id)
        {
            return dbSet.Find(id);
        }

        public void Inserir(TEntidade entidade)
        {
            dbSet.Add(entidade);
        }

        public void Alterar(TEntidade entidade)
        {
            contexto.Entry(entidade).State = EntityState.Modified;
        }

        public void Remover(int id)
        {
            dbSet.Remove(Obter(id));
        }

        public void Remover(TEntidade entidade)
        {
            dbSet.Remove(entidade);
        }

        public void Dispose()
        {
            if (contexto != null)
            {
                contexto.Dispose();
            }
        }
    }
}
