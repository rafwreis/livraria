using Livraria.Dominio.Interfaces.Infraestrutura;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Data.Configuracao
{
    public class UnidadeTrabalho : IUnidadeTrabalho
    {
        private readonly DbContext dbContext;

        public UnidadeTrabalho(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Salvar()
        {
            dbContext.SaveChanges();
        }
    }
}
