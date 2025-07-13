using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemBurger.Domain
{
    public class ItemPedido
    {
        [Key]
        public int Id { get; set; }

        public int Quantidade { get; set; }

        public int IdProduto { get; set; }

        public required Produto Produto { get; set; }

        public int IdPedido { get; set; }

        public required Pedido Pedido { get; set; }

        public decimal SubTotal { get; set; }
    }
}
