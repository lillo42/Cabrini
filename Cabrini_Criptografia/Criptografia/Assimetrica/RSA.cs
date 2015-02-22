﻿using Criptografia.Execoes;
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
            BigInteger d;
            BigInteger z;
            ResolveNumerosParaDeCriptar(p, q,out d,out n, out z);            
            BigInteger e = DescobreNumeroResulta1(d, z);
            mensage = TransformaMensaemEmTexto(mensage, n);
            return FazContaComMensagem(mensage,e,n);
        }


        public string Decriptografa(BigInteger p, BigInteger q, string mensage)
        {
            BigInteger n;
            BigInteger d;
            ResolveNumerosParaDeCriptar(p, q, out d, out n);
            mensage = FazContaComMensagem(mensage, d, n);
            return TransformaTextoEmMensagem(mensage, n);
        }

        private string FazContaComMensagem(string mensagem, BigInteger multiplicador, BigInteger modulo )
        {
            var retorno = new StringBuilder();
            int tamanho = modulo.ToString().Length;
            for (int i = 0; i < mensagem.Length; i += tamanho)
            {
                BigInteger valor;
                if(BigInteger.TryParse(mensagem.Substring(i, tamanho),out valor))
                    retorno.Append(BigInteger.ModPow(valor, multiplicador,modulo).ToString());
            }
            return retorno.ToString();
        }

        private void ResolveNumerosParaDeCriptar(BigInteger p, BigInteger q, out BigInteger d, out BigInteger n)
        {
            BigInteger z;
            ResolveNumerosParaDeCriptar(p, q, out d, out n, out z);
        }

        private void ResolveNumerosParaDeCriptar(BigInteger p, BigInteger q, out BigInteger d, out BigInteger n, out BigInteger z)
        {
            if (!IsPrimo(p) || !IsPrimo(q))
                throw new NotPrimeNumber("Valor de uma das chaves invalido");
            n = BigInteger.Multiply(p, q);
            z = BigInteger.Multiply(p - 1, q - 1);
            d = GetUmNaoDivivel(z);
        }

        private string TransformaMensaemEmTexto(string mensagem, BigInteger tamanhoModulo)
        {
            int tamanhoN = tamanhoModulo.ToString().Length;
            var textoNumero = new StringBuilder();
            for (int i = 0; i < mensagem.Length; i++)
                textoNumero.Append(((int)mensagem[i]).ToString("00"));

            int falta = textoNumero.Length % tamanhoN;
            for (int i = 0; i < falta; i++)
                textoNumero.Append('0');
            return textoNumero.ToString();
        }

        private string TransformaTextoEmMensagem(string mensagem, BigInteger tamanhoModulo)
        {
            int tamanhoN = tamanhoModulo.ToString().Length;

            var textoNumero = new StringBuilder();
            for (int i = 0; i < mensagem.Length; i+=2)
                textoNumero.Append((char)Convert.ToInt32(mensagem.Substring(i, 2)));

            return textoNumero.ToString();
        }

        private bool IsPrimo(BigInteger valor)
        {
            if (valor.IsOne)
                return false;
            else if (valor ==  2)
                return true;

            for (BigInteger i = 2; BigInteger.Pow(i,2) <= valor; ++i)
            {
                if (BigInteger.Remainder(valor,i) == 0)
                    return false;
            }

            return true;
        }

        private BigInteger DescobreNumeroResulta1(BigInteger multiplicado, BigInteger modulo)
        {
            BigInteger retorno;

            for (retorno = new BigInteger(1); BigInteger.Pow(retorno, 2) <= multiplicado; retorno = BigInteger.Add(retorno, 1))
            {
                if (BigInteger.Remainder(BigInteger.Multiply(retorno, multiplicado), modulo) == 1)
                    return retorno;
            }
            throw new KeyNotFoundException("Valor da chaver não achada");
        }

        private BigInteger GetUmNaoDivivel(BigInteger numero)
        {
            BigInteger retorno;

            for (retorno = 2; BigInteger.Pow(retorno, 2) <= numero; retorno = BigInteger.Add(retorno,1))
            {
                if (BigInteger.GreatestCommonDivisor(numero, retorno) == 1)
                    return retorno;
            }
            throw new KeyNotFoundException("Valor da chaver não achada");
        }
    }
}
