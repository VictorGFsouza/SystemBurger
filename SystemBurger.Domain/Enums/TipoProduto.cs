using System.ComponentModel.DataAnnotations;

namespace SystemBurger.Domain.Enums
{
    public enum TipoProduto
    {
        [Display(Name = "Lanche")]
        Lanche = 1,

        [Display(Name = "Bebida")]
        Bebida = 2,

        [Display(Name = "Porção")]
        Porcao = 3,

        [Display(Name = "Sobremesa")]
        Sobremesa = 4
    }
}
