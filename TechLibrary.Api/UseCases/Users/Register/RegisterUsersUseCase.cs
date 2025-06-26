using FluentValidation.Results;
using TechLibrary.Api.Domain.Entities;
using TechLibrary.Api.Infraestructure.DataAccess;
using TechLibrary.Api.Infraestructure.Security.Cryptography;
using TechLibrary.Api.Infraestructure.Security.Tokens.Access;
using TechLibrary.Comunication.Requests;
using TechLibrary.Comunication.Responses;
using TechLibrary.Exception;

namespace TechLibrary.Api.UseCases.Users.Register
{
public class RegisterUsersUseCase
{
        public ResponseRegisteredUserJson Execute(RequestUserJson request)
        {
            var dbContext = new TechLibraryDbContext();
            Validate(request,dbContext);
            var crypthography = new BcryptAlgorithm();
            var entity = new User
            {
                Name = request.Name,
                Email = request.Email,
                Password = crypthography.HashPassword(request.Password),
            };
            
            dbContext.User.Add(entity);
            dbContext.SaveChanges();
            var tokenGenerator = new JwtTokenGenerator();
            return new ResponseRegisteredUserJson
            {
                Name = entity.Name,
                AccessToken = tokenGenerator.Generate(entity)


            };
        }
        private void Validate(RequestUserJson request, TechLibraryDbContext dbContext)
        {
            var validator = new RegisterUserValidator();
            var result = validator.Validate(request);
            var existUserWithEmail = dbContext.User.Any(user => user.Email.Equals(request.Email));
            if (existUserWithEmail)
                result.Errors.Add(new ValidationFailure("Email", "Email já cadastrado"));
            if (result.IsValid == false)
            {
               var errorMessages =  result.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ErrorOnValidationException(errorMessages);
            }
        }

    }
}
