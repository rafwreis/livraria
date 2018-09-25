using Livraria.Aplicacao;
using Livraria.Aplicacao.Interfaces;
using Livraria.Data.Configuracao;
using Livraria.Data.Contexto;
using Livraria.Data.Repositorios;
using Livraria.Dominio.Interfaces.Infraestrutura;
using Livraria.Dominio.Interfaces.Repositorios;
using Livraria.Dominio.Interfaces.Servicos;
using Livraria.Dominio.Servicos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Livraria.Api
{
    public class Register
    {
        public IServiceCollection RegisterClass(IServiceCollection services, string stringConexao)
        {
            services.AddScoped<DbContext, LivrariaContexto>();
            services.AddScoped<IUnidadeTrabalho, UnidadeTrabalho>();

            services.AddScoped<ILivroRepositorio, LivroRepositorio>();
            services.AddScoped<ILivroServico, LivroServico>();
            services.AddScoped<ILivroAppServico, LivroAppServico>();

            return services.AddDbContext<LivrariaContexto>(options => options.UseSqlServer(stringConexao));
        }
    }
}
