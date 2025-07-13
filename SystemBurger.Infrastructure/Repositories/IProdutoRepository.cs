using SystemBurger.Domain;

namespace SystemBurger.Infrastructure.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Get(string? descricao, byte? tipoProduto);

        Produto GetById(int id);

        Produto Post(Produto produto);

        Produto Put(Produto produto);

        void Delete(int id);
    }
}
