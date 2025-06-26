using FluentValidation;
using TechLibrary.Comunication.Requests;

namespace TechLibrary.Api.UseCases.Medicamento.Register
{
    public class RegisterMedicamentoValidator : AbstractValidator<RequestMedicamentoJson>
    {
        public RegisterMedicamentoValidator()
        {
            RuleFor(request => request.Nome).NotEmpty().WithMessage("O nome é obrigatorio");
            RuleFor(request => request.Quantidade).GreaterThan(0).WithMessage("É necessário possuir pelo menos 1 item no estoque.");
        }
    }
}
