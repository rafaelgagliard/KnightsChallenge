using Domain.Constants;
using Domain.Entities;
using FluentValidation;

namespace Domain.Validations
{
    public class KnightsValidations : AbstractValidator<Knight>
    {
        //Criado para indicar a opção de validação
        public KnightsValidations() {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(200);

            RuleFor(x => x.KeyAttribute).Must(x => KnightsConstants.Attributes.Contains(x));
        }
    }
}
