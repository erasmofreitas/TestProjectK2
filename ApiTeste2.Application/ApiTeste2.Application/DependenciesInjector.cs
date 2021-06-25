using ApiTeste2.Application.Application;
using ApiTeste2.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ApiTeste2.Application
{
    public class DependenciesInjector
    {
        public static void Register(IServiceCollection svcCollection)
        {
            #region Application
            svcCollection.AddScoped<ICalcularJurosApplication, CalcularJurosApplication>();
            svcCollection.AddScoped<ICodeApplication, CodeApplication>();

            #endregion

        }
    }
}
