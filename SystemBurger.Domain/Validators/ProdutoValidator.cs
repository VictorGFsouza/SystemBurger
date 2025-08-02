using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBurger.Domain.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("O nome do produto é obrigatório.")
                .Length(3, 100).WithMessage("O nome do produto deve ter entre 3 e 100 caracteres.");
            RuleFor(p => p.Descricao)
                .NotEmpty().WithMessage("A descrição do produto é obrigatória.")
                .Length(10, 500).WithMessage("A descrição do produto deve ter entre 10 e 500 caracteres.");
            RuleFor(p => p.Valor)
                .GreaterThan(0).WithMessage("O preço do produto deve ser maior que zero.");
        }
    }
}
