using System.ComponentModel.DataAnnotations;

namespace SystemBurger.Domain.Enums
{
    public enum Status
    {
        [Display(Name = "Lançado")]
        Lancado = 1,

        [Display(Name = "Em preparo")]
        EmPreparo = 2,

        [Display(Name = "Finalizado")]
        Finalizado = 3,

        [Display(Name = "Pago")]
        Pago = 4
    }
}
