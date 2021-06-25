using ApiTeste2.Application.Interfaces;
using Refit;
using System;
using System.Threading.Tasks;

namespace ApiTeste2.Application.Application
{
    public class CodeApplication : ICodeApplication
    {
        public string GetUrlGitHub()
        {
            string result = "https://github.com/erasmofreitas/TestProjectK2";
            return result;
        }
    }
}
