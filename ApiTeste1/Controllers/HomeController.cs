
using ApiTeste1.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTeste1.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ITaxaJurosApplication _taxaJurosApplication;

        public HomeController(ITaxaJurosApplication taxaJurosApplication)
        {
            _taxaJurosApplication = taxaJurosApplication;
        }
        [HttpGet]
        [Route("taxaJuros")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [SwaggerOperation(OperationId = "TaxaJuros")]
        public async Task<IActionResult> GetTaxaJuros()
        {
            try
            {
                var result = _taxaJurosApplication.GetTaxaJuros();
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
