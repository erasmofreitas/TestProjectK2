using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiTeste2.Application.Interfaces
{
    public interface ICalcularJurosApplication
    {
        Task<decimal> CalcularJuros(decimal valorInicial, int meses);
        [Get("/taxaJuros")]
        Task<decimal> GetTaxaJuros();
    }
}
