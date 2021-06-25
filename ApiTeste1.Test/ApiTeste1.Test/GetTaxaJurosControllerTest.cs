using ApiTeste1.Application.Interfaces;
using ApiTeste1.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiTeste1.Test
{
    public class GetTaxaJurosControllerTest
    {
        HomeController _controller;
        ITaxaJurosApplication _taxaJurosApplication;

        public GetTaxaJurosControllerTest()
        {
            _taxaJurosApplication = new GetTaxaJurosTest();
            _controller = new HomeController(_taxaJurosApplication);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            var okResult = _controller.GetTaxaJuros().Result;            
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsTaxaJuros()
        {
            var okResult = _controller.GetTaxaJuros().Result as OkObjectResult;

            var taxaJuros = Assert.IsType<decimal>(okResult.Value);
            Assert.Equal(0.01m, taxaJuros);
        }
    }
}
