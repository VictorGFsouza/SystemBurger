using Microsoft.AspNetCore.Mvc;
using SystemBurger.Domain;
using SystemBurger.Infrastructure.Repositories;

namespace SystemBurger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _repository;
        public ProdutoController(IProdutoRepository repository) 
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult Get(string? descricao, byte? tipoProduto)
        {
            _repository.Get(descricao, tipoProduto);
            return Ok();
        }

        [HttpGet("Id")]
        public ActionResult GetById(int id)
        {
            _repository.GetById(id);
            return Ok();
        }

        [HttpPost]
        public ActionResult Post(Produto produto)
        {
            _repository.Post(produto);
            return Ok();
        }

        [HttpPut]
        public ActionResult Put(Produto produto)
        {
            _repository.Put(produto);
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok();
        }
    }
}
