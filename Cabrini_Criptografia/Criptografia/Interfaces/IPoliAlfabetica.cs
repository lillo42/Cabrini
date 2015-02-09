using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia.Interfaces
{
    public interface IPoliAlfabetica
    {
        string Criptografa(string texto, string chave);

        string Decriptografa(string texto, string chave);
    }
}
