using ApiTeste2.Application.Interfaces;
using ApiTeste2.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ApiTeste2.Test
{
   public class CalcularJurosControllerTest
    {
        HomeController _controller;
        ICalcularJurosApplication _calcularJurosApplication;
        ICodeApplication _codeApplication;

        public CalcularJurosControllerTest()
        {
            _calcularJurosApplication = new CalcularJurosTest();
            _codeApplication = new ShowMeTheCodeTest();
            _controller = new HomeController(_calcularJurosApplication, _codeApplication);
        }

        [Theory]
        [InlineData(100, 5)]
        public void Get_CalcularJuros_WhenCalled_ReturnsOkResult(decimal valorInicial, int meses)
        {
            var okResult = _controller.CalcularJuros(valorInicial, meses).Result;
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void Get_ShowMeTheCode_WhenCalled_ReturnsOkResult()
        {
            var okResult = _controller.ShowMeTheCode().Result;
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Theory]
        [InlineData(100, 5)]
        public void Get_WhenCalled_ReturnsCalcularJuros(decimal valorInicial, int meses)
        {
            var okResult = _controller.CalcularJuros(valorInicial, meses).Result as OkObjectResult;

            var taxaJuros = Assert.IsType<decimal>(okResult.Value);
            Assert.Equal(105.10m, taxaJuros);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsShowMeTheCode()
        {
            var okResult = _controller.ShowMeTheCode().Result as OkObjectResult;

            var urlGitHub = Assert.IsType<string>(okResult.Value);
            Assert.Equal("https://github.com/erasmofreitas/TestProjectK2", urlGitHub);
        }
    }
}
