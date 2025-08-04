using SystemBurger.Domain.Dtos;
using SystemBurger.Domain.Entities;
using SystemBurger.Domain.Enums;
using SystemBurger.Infrastructure.Data;

namespace SystemBurger.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext ctx;

        public ProdutoRepository(AppDbContext context)
        {
            ctx = context;
        }

        public IEnumerable<Produto> Get(string? descricao, byte? tipoProduto)
        {
            var produtos = ctx.Produto.ToList();

            if (descricao is not null)
                produtos = produtos.Where(p => p.Nome.ToUpper().Contains(descricao.ToUpper()) || p.Descricao.ToUpper().Contains(descricao.ToUpper())).ToList();

            if (tipoProduto is not null)
                produtos = produtos.Where(p => p.TipoProduto == tipoProduto).ToList();

            return produtos;
        }

        public ProdutoDTO GetById(int id)
        {
            var produto = ctx.Produto.FirstOrDefault(p => p.Id == id);

            if (produto is null)
                throw new Exception("Produto não encontrado");

            return FormatarProduto(produto);
        }

        public ProdutoDTO Post(Produto produto)
        {
            ctx.Add(produto);
            ctx.SaveChanges();
            return FormatarProduto(produto);
        }

        public ProdutoDTO Put(Produto produto)
        {
            ctx.Update(produto);
            ctx.SaveChanges();
            return FormatarProduto(produto);
        }

        public void Delete(int id)
        {
            var produto = ctx.Produto.FirstOrDefault(p => p.Id == id);

            if (produto is null)
                throw new Exception("Produto não encontrado");

            ctx.Remove(produto);
            ctx.SaveChanges();
        }

        public ProdutoDTO FormatarProduto(Produto produto)
        {
            return new ProdutoDTO
            {
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                TipoProduto = ((TipoProduto)produto.TipoProduto).GetDisplayName(),
                Valor = produto.Valor
            };
        }
    }
}
