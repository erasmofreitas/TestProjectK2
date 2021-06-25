using ApiTeste1.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTeste1.Test
{
    public class GetTaxaJurosTest : ITaxaJurosApplication
    {
        public decimal GetTaxaJuros()
        {
            decimal taxaJuros = 0.01m;
            return taxaJuros;
        }
    }
}
