using Microsoft.AspNetCore.Mvc;
using TechLibrary.Api.UseCases.Login.DoLogin;
using TechLibrary.Comunication.Requests;
using TechLibrary.Comunication.Responses;

namespace TechLibrary.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ListarMedicamentoController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status401Unauthorized)]
        public IActionResult DoListarMed(RequestListarMedicamentoJson request)
        {
            var useCase = new DoListarMedicamentoUseCase();
            var response = useCase.Execute(request);
            return Ok(response);

        }
    }
}
