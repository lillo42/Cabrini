using Criptografia.Execoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia.Assimetrica
{
    public class RSA
    {
        public string Criptografa(BigInteger p, BigInteger q, string mensage)
        {
            BigInteger n;
            BigInteger e;
            BigInteger z;
            ResolveNumerosParaDeCriptar(p, q,out e,out n, out z);            
            BigInteger d = DescobreD(e, z);
            int[] numTexto = TransformaMensaemEmNumero(mensage);
            return CriptografaTexto(numTexto, d, n);
        }


        public string Decriptografa(BigInteger p, BigInteger q, string mensage)
        {
            BigInteger n;
            BigInteger e;
            ResolveNumerosParaDeCriptar(p, q, out e, out n);
            int[] textoDes = DecriptografaTexto(mensage, e, n);
            return TransformaNumeroEmMensagem(textoDes);
        }

        private string CriptografaTexto(int[] mensagem, BigInteger multiplicador, BigInteger modulo )
        {
            var retorno = new StringBuilder();

            for (int i = 0; i < mensagem.Length; i++)
                retorno.Append(BigInteger.ModPow(mensagem[i], multiplicador,modulo).ToString("00"));

            return retorno.ToString();
        }

        private int[] DecriptografaTexto(string mensagem, BigInteger multiplicador, BigInteger modulo)
        {
            var retorno = new int[mensagem.Length / 2];
            int posicaoTexto = 0;

            for (int i = 0; i < mensagem.Length / 2; i++)
            {
                int valor = Convert.ToInt32(mensagem.Substring(posicaoTexto, 2));
                retorno[i] = (int)BigInteger.ModPow(valor, multiplicador, modulo);
                posicaoTexto += 2;
            }

            return retorno;
        }

        private void ResolveNumerosParaDeCriptar(BigInteger p, BigInteger q, out BigInteger d, out BigInteger n)
        {
            BigInteger z;
            ResolveNumerosParaDeCriptar(p, q, out d, out n, out z);
        }

        private void ResolveNumerosParaDeCriptar(BigInteger p, BigInteger q, out BigInteger e, out BigInteger n, out BigInteger z)
        {
            if (!IsPrimo(p) || !IsPrimo(q))
                throw new NotPrimeNumber("Valor de uma das chaves invalido");
            n = BigInteger.Multiply(p, q); //N
            z = BigInteger.Multiply(p - 1, q - 1); //Fi
            e = DescobreE(z,n);
        }

        private int[] TransformaMensaemEmNumero(string mensagem)
        {
            mensagem = mensagem.ToUpper();
            var retorno = new int[mensagem.Length];

            for(int i =0;i< mensagem.Length;i++)
                retorno[i] = (int)mensagem[i] - 65;

            return retorno;
        }

        private string TransformaNumeroEmMensagem(int[] mensagem)
        {
            var textoNumero = new StringBuilder();

            for (int i = 0; i < mensagem.Length; i+=2)
                textoNumero.Append((char)(mensagem[i] + 65));

            return textoNumero.ToString();
        }

        private bool IsPrimo(BigInteger valor)
        {
            if (valor.IsOne)
                return false;
            else if (valor == 2)
                return true;
            else if (BigInteger.Remainder(valor, 2) == 0)
                return false;

            for (BigInteger i = 3; BigInteger.Pow(i,2) <= valor; i+=2)
            {
                if (BigInteger.Remainder(valor,i) == 0)
                    return false;
            }

            return true;
        }

        private BigInteger DescobreD(BigInteger multiplicado, BigInteger modulo)
        {
            BigInteger retorno = new BigInteger(1);

            while (retorno <= modulo)
            {
                var a = BigInteger.Multiply(retorno, multiplicado);
                var b = BigInteger.Remainder(BigInteger.Multiply(retorno, multiplicado), modulo);
                if (BigInteger.Remainder(BigInteger.Multiply(retorno,multiplicado), modulo) == 1)
                    return retorno;
                retorno++;
            }

            throw new KeyNotFoundException("Valor da chaver não achada");
        }

        private BigInteger DescobreE(BigInteger numero, BigInteger n)
        {
            BigInteger retorno;

            for (retorno = 2; retorno < n; retorno = BigInteger.Add(retorno, 1))
            {
                if (BigInteger.GreatestCommonDivisor(numero, retorno) == 1)
                    return retorno;
            }
            throw new KeyNotFoundException("Valor da chaver não achada");
        }
    }
}
