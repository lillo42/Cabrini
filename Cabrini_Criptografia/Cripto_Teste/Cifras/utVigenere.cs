using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Criptografia.Crifras;
using System.Diagnostics;

namespace Cripto_Teste.Cifras
{
    [TestClass]
    public class utVigenere : ITesteCriptografica
    {

        [TestMethod]
        public void Criptografia()
        {
            var vigenere = new Vigenere();

            string texto = "rafael";
            string chave = "lillo";

            var retonro = vigenere.Criptografa(texto, chave);

            Console.WriteLine(retonro);
        }

        [TestMethod]
        public void DeCriptografia()
        {
            var vigenere = new Vigenere();

            string texto = "rafael";
            string chave = "lillo";

            var retonro1 = vigenere.Criptografa(texto, chave);

            var retonro2 = vigenere.Decriptografa(retonro1, chave);

            Console.WriteLine(retonro2);
        }
    }
}
