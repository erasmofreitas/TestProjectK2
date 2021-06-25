using ApiTeste2.Application.Interfaces;
using Refit;
using System;
using System.Threading.Tasks;

namespace ApiTeste2.Application.Application
{
    public class CalcularJurosApplication : ICalcularJurosApplication
    {
        public async Task<decimal> CalcularJuros(decimal valorInicial, int meses)
        {
            try
            {

                decimal taxaJuros = await GetTaxaJuros();
                var result = valorInicial * Convert.ToDecimal((Math.Pow(Convert.ToDouble(1 + taxaJuros), meses)));
                return Math.Truncate(result * 100) / 100;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Task<decimal> GetTaxaJuros()
        {
            try
            {
                var client = RestService.For<ICalcularJurosApplication>("https://localhost:44331");
                var result = client.GetTaxaJuros();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
