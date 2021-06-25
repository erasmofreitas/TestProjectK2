using ApiTeste1.Application.Application;
using ApiTeste1.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTeste1.Application
{
    public class DependenciesInjector
    {
        public static void Register(IServiceCollection svcCollection)
        {
            #region Application
            svcCollection.AddScoped<ITaxaJurosApplication, TaxaJurosApplication>();

            #endregion

        }
    }
}
