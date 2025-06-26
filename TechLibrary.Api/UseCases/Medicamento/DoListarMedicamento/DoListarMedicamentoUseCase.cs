using TechLibrary.Api.Infraestructure.DataAccess;
using TechLibrary.Api.Infraestructure.Security.Cryptography;
using TechLibrary.Api.Infraestructure.Security.Tokens.Access;
using TechLibrary.Comunication.Requests;
using TechLibrary.Comunication.Responses;
using TechLibrary.Exception;

namespace TechLibrary.Api.UseCases.Login.DoLogin
{
    public class DoListarMedicamentoUseCase
    {
        public ResponseRegisteredMedicamentoJson Execute(RequestListarMedicamentoJson request)
        {
            var dbContext = new TechLibraryDbContext();
            var user = dbContext.Medicamento.FirstOrDefault(user => user.Nome.Equals(request.Nome));
            if (user is null)          
                throw new DataException();
            
            return new ResponseRegisteredMedicamentoJson
            {
                Nome = user.Nome,   
                Quantidade = user.Quantidade,
                Fornecedor = user.Fornecedor,
                Validade = user.Validade    
            };
        }
    }
}
