using System.ComponentModel.DataAnnotations;

namespace SystemBurger.Domain.Enums
{
    public enum TipoPagamento
    {
        [Display(Name = "Crédito")]
        Credito = 1,

        [Display(Name = "Débito")]
        Debito = 2,

        [Display(Name = "Pix")]
        Pix = 3,

        [Display(Name = "Dinheiro")]
        Dinheiro = 4
    }
}
