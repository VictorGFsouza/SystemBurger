using System.ComponentModel.DataAnnotations;

namespace SystemBurger.Domain.Entities
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        public required string Nome { get; set; }

        public required string Descricao { get; set; }

        public byte TipoProduto { get; set; }

        public decimal Valor { get; set; }
    }
}
