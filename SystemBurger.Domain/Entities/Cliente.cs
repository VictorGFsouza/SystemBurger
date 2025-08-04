using System.ComponentModel.DataAnnotations;

namespace SystemBurger.Domain.Entities
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        public required string Nome { get; set; }

        public string? Telefone { get; set; }
    }
}
