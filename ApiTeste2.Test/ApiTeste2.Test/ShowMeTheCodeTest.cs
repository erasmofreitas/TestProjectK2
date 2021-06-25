using ApiTeste2.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTeste2.Test
{
    public class ShowMeTheCodeTest : ICodeApplication
    {
        public string GetUrlGitHub()
        {
            string result = "https://github.com/erasmofreitas/TestProjectK2";
            return result;
        }
    }
}
