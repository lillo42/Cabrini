using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Criptografia.Assimetrica;
using System.Numerics;
using System.Threading;

namespace Cripto_Teste.Assimetrica
{
    [TestClass]
    public class utRSA
    {
        [TestMethod]
        public void TesteRSA()
        {
            var r = new RSA();
            string mensagem = "c";

            var t = r.Criptografa(29, 3, mensagem);

            Console.WriteLine(t);
        }

        [TestMethod]
        public void TesteDecript()
        {
            var r = new RSA();
            string mensagem = "26";

            var t = r.Decriptografa(29, 3, mensagem);

            Console.WriteLine(t);
        }

        [TestMethod]
        public void TesteCriptDecrip1()
        {
            BigInteger p = 29;
            BigInteger q = 3;

            var r = new RSA();
            string mensagem = "c";

            var c = r.Criptografa(p, q, mensagem);

            var t = r.Decriptografa(29, 3, c);
            
        }

        [TestMethod]
        public void TesteCriptDecrip2()
        {
            BigInteger p = GeraPrimoBigInt();
            BigInteger q = GeraPrimoBigInt();

            var r = new RSA();
            string mensagem = "c";

            var c = r.Criptografa(p, q, mensagem);

            var t = r.Decriptografa(29, 3, c);
            
        }

        private BigInteger GeraPrimoBigInt()
        {
            BigInteger retorno;
            do
            {
                retorno = getRandom(10);
                if (retorno < 0)
                    retorno = BigInteger.Multiply(retorno, -1);
                Thread.Sleep(100);
            }while(!IsPrimo(retorno));


            return retorno;
        }

        public BigInteger getRandom(int length)
        {
            Random random = new Random();
            byte[] data = new byte[length];
            random.NextBytes(data);
            return new BigInteger(data);
        }

        private bool IsPrimo(BigInteger valor)
        {
            if (valor.IsOne)
                return false;
            else if (valor == 2)
                return true;
            else if (BigInteger.Remainder(valor, 2) == 0)
                return false;

            for (BigInteger i = 3; BigInteger.Pow(i, 2) <= valor; i += 2)
            {
                if (BigInteger.Remainder(valor, i) == 0)
                    return false;
            }

            return true;
        }
    }
}
