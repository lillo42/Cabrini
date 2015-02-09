using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia.Interfaces
{
    public interface IMonoAlfabetica
    {
        string Criptografa(string texto, int chave = 3);

        string Decriptografa(string texto, int chave = 3);
    }
}
