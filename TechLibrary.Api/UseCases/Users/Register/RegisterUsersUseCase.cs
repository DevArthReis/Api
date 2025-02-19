using TechLibrary.Comunication.Requests;
using TechLibrary.Comunication.Responses;

namespace TechLibrary.Api.UseCases.Users.Register
{
public class RegisterUsersUseCase
{
        public ResponseRegisteredUserJson Execute(RequestUserJson request)
        {
            Validate(request);
            return new ResponseRegisteredUserJson
            {


            };
        }
        private void Validate(RequestUserJson request)
        {
            var validator = new RegisterUserValidator();
            var result = validator.Validate(request);
            if (result.IsValid == false)
            {
               var errorMessagens =  result.Errors.Select(error => error.ErrorMessage).ToList();
                throw new Exception();
            }
        }

    }
}
