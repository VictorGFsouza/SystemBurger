using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using SystemBurger.Domain.Dtos;
using SystemBurger.Domain.Entities;
using SystemBurger.Infrastructure.Repositories;

namespace SystemBurger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _repository;
        private readonly IValidator<Produto> _validator;

        public ProdutoController(IProdutoRepository repository, IValidator<Produto> validator) 
        {
            _repository = repository;
            _validator = validator;
        }

        [HttpGet]
        public ActionResult Get(string? descricao, byte? tipoProduto)
        {
            var produtos = _repository.Get(descricao, tipoProduto);
            return Ok(produtos);
        }

        [HttpGet("Id")]
        public ActionResult GetById(int id)
        {
            return Ok(_repository.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Produto produto)
        {
            var result = _validator.Validate(produto);

            if (!result.IsValid)
                return BadRequest(result.Errors);

            return Ok(_repository.Post(produto));
        }

        [HttpPatch]
        public ActionResult Patch([FromBody] Produto produto)
        {
            var result = _validator.Validate(produto);

            if (!result.IsValid)
                return BadRequest(result.Errors);

            return Ok(_repository.Put(produto));
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                _repository.Delete(id);
                return Ok("Exluído com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
