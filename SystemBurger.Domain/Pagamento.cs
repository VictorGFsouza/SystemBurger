using System.ComponentModel.DataAnnotations;

namespace SystemBurger.Domain
{
    public class Pagamento
    {
        [Key]
        public int Id { get; set; }

        public int IdPedido { get; set; }

        public required Pedido Pedido { get; set; }

        public decimal Valor { get; set; }

        public byte TipoPagamento { get; set; }

        public DateTime Data { get; set; }
    }
}
