using System.ComponentModel.DataAnnotations;

namespace SystemBurger.Domain.Entities
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public decimal Valor { get; set; }

        public byte Status { get; set; }

        public int IdCliente { get; set; }

        public required Cliente Cliente { get; set; }

        public int? Mesa {  get; set; }

        public bool Retirada { get; set; }
    }
}
