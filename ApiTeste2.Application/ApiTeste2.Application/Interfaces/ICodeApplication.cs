using System.Threading.Tasks;

namespace ApiTeste2.Application.Interfaces
{
    public interface ICodeApplication
    {
        Task<string> GetUrlGitHub();
    }
}
