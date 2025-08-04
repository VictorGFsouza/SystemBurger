using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBurger.Domain.Dtos
{
    public class ProdutoDTO
    {
        public required string Nome { get; set; }

        public required string Descricao { get; set; }

        public required string TipoProduto { get; set; }

        public decimal Valor { get; set; }
    }
}
