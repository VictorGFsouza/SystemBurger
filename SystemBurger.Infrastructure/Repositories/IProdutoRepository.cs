using SystemBurger.Domain.Dtos;
using SystemBurger.Domain.Entities;

namespace SystemBurger.Infrastructure.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Get(string? descricao, byte? tipoProduto);

        ProdutoDTO GetById(int id);

        ProdutoDTO Post(Produto produto);

        ProdutoDTO Put(Produto produto);

        void Delete(int id);
    }
}
