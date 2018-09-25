using Livraria.Aplicacao.Interfaces;
using Livraria.Dominio.Entidades;
using Livraria.Dominio.Interfaces.Infraestrutura;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Livraria.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroAppServico livroAppServico;
        private readonly IUnidadeTrabalho unidadeTrabalho;

        public LivrosController(ILivroAppServico livroAppServico,
            IUnidadeTrabalho unidadeTrabalho)
        {
            this.livroAppServico = livroAppServico;
            this.unidadeTrabalho = unidadeTrabalho;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] Livro livro)
        {
            //TODO:Implementar DTO com auto mapper
            var result = livroAppServico.Obter();
            return new OkObjectResult(result);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Livro livro)
        {
            if (ModelState.IsValid)
            {
                //TODO:Implementar DTO com auto mapper
                livroAppServico.Inserir(livro);
                unidadeTrabalho.Salvar();

                return new OkResult();
            }

            return new BadRequestResult();
        }

        [HttpPut]
        public IActionResult Put([FromBody]Livro livro)
        {
            if (ModelState.IsValid)
            {
                //TODO:Implementar DTO com auto mapper
                livroAppServico.Alterar(livro);
                unidadeTrabalho.Salvar();

                return new OkResult();
            }

            return new BadRequestResult();
        }

        public IActionResult Delete(int id)
        {
            try
            {
                livroAppServico.Remover(id);
                unidadeTrabalho.Salvar();

                return new OkResult();
            }
            catch (Exception)
            {
                //Log
                return new BadRequestResult();
            }
        }
    }
}