using ApiTeste2.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;

namespace ApiTeste2.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ICalcularJurosApplication _calcularJurosApplication;
        private readonly ICodeApplication _codeApplication;

        public HomeController(ICalcularJurosApplication calcularJurosApplication, ICodeApplication codeApplication)
        {
            _calcularJurosApplication = calcularJurosApplication;
            _codeApplication = codeApplication;
        }
        [HttpGet]
        [Route("calcularjuros")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [SwaggerOperation(OperationId = "calcularjuros")]
        public async Task<IActionResult> CalcularJuros(decimal valorInicial, int meses)
        {
            try
            {
                var result = await _calcularJurosApplication.CalcularJuros(valorInicial, meses);
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("showmethecode")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [SwaggerOperation(OperationId = "showmethecode")]
        public async Task<IActionResult> ShowMeTheCode()
        {
            try
            {
                var result = _codeApplication.GetUrlGitHub();
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
