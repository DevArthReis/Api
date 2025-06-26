using FluentValidation.Results;
using TechLibrary.Api.Domain.Entities;
using TechLibrary.Api.Infraestructure.DataAccess;
using TechLibrary.Api.Infraestructure.Security.Cryptography;
using TechLibrary.Api.Infraestructure.Security.Tokens.Access;
using TechLibrary.Comunication.Requests;
using TechLibrary.Comunication.Responses;
using TechLibrary.Exception;

namespace TechLibrary.Api.UseCases.Medicamento.Register
{
public class RegisterMedicamentoUseCase
{
        public ResponseRegisteredMedicamentoJson Execute(RequestMedicamentoJson request)
        {
            var dbContext = new TechLibraryDbContext();
            Validate(request,dbContext);
            var crypthography = new BcryptAlgorithm();
            var entity = new TechLibrary.Api.Domain.Entities.Medicamento
            {
                Nome = request.Nome,
                Fornecedor = request.Fornecedor,   
                Quantidade = request.Quantidade,
                Validade = request.Validade
            };
            
            dbContext.Medicamento.Add(entity);
            dbContext.SaveChanges();

            return new ResponseRegisteredMedicamentoJson
            {
                Nome = entity.Nome,
                Quantidade = entity.Quantidade,
                Fornecedor = entity.Fornecedor,
                Validade = entity.Validade
            };
        }
        private void Validate(RequestMedicamentoJson request, TechLibraryDbContext dbContext)
        {
            var validator = new RegisterMedicamentoValidator();
            var result = validator.Validate(request);
            var existUserWithEmail = dbContext.Medicamento.Any(user => user.Nome.Equals(request.Nome));
            if (existUserWithEmail)
                result.Errors.Add(new ValidationFailure("Medicamento", "Medicamento já cadastrado"));
            if (result.IsValid == false)
            {
               var errorMessages =  result.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ErrorOnValidationException(errorMessages);
            }
        }

    }
}
