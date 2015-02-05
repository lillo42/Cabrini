using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia.Crifras
{
    public class Vigenere
    {
        public string Criptografa(string texto, string chave)
        {
            var retorno = new StringBuilder();

            for (int i = 0; i < texto.Length;i++ )
            {
                int valorRetorno = ((int)chave[i % chave.Length] + (int)texto[i]) % 256; 
                retorno.Append((char)valorRetorno);
            }

            return retorno.ToString();
        }

        public string Decriptografa(string texto, string chave)
        {
            var retorno = new StringBuilder();

            for (int i = 0; i < texto.Length; i++)
            {
                int valorRetorno = (((int)texto[i] - (int)chave[i % chave.Length] ) + 256) % 256;
                retorno.Append((char)valorRetorno);
            }

            return retorno.ToString();
        }
    }
}
