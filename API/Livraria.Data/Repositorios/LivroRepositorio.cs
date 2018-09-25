using Livraria.Dominio.Entidades;
using Livraria.Dominio.Interfaces.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Data.Repositorios
{
    public class LivroRepositorio : BaseRepositorio<Livro>, ILivroRepositorio
    {
        public LivroRepositorio(DbContext contexto)
            :base(contexto)
        {

        }
    }
}
