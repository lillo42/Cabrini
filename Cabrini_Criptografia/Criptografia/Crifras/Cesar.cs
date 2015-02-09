using Criptografia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia.Crifras
{
    public class Cesar : IMonoAlfabetica
    {
        public string Criptografa(string texto, int chave = 3)
        {
            return DeOuCriptogrfa(texto, chave );
        }

        public string Decriptografa(string texto, int chave = 3)
        {
            return DeOuCriptogrfa(texto, (chave * -1));
        }

        private string DeOuCriptogrfa(string texto,int chave)
        {
            var retorno = new StringBuilder();

            for (int i = 0; i < texto.Length; i++)
            {
                int valorConversao = (int)texto[i] + chave;
                valorConversao = valorConversao % 256;
                retorno.Append((char)valorConversao);
            }

            return retorno.ToString();
        }
    }
}
