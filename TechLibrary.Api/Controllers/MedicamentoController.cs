using Microsoft.AspNetCore.Mvc;
using TechLibrary.Api.UseCases.Login.DoLogin;
using TechLibrary.Api.UseCases.Medicamento.Register;
using TechLibrary.Api.UseCases.Users.Register;
using TechLibrary.Comunication.Requests;
using TechLibrary.Comunication.Responses;

namespace TechLibrary.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MedicamentoController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status401Unauthorized)]
        public IActionResult Register(RequestMedicamentoJson request)
        {

            var useCase = new RegisterMedicamentoUseCase();
            var response = useCase.Execute(request);
            return Created(string.Empty, response);

        }
    }
}
