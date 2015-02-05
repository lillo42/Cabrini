using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Criptografia.Crifras;

namespace Cripto_Teste.Cifras
{
    [TestClass]
    public class utCesar : ITesteCriptografica
    {
        [TestMethod]
        public void Criptografia()
        {
            var cesar = new Cesar();

            string texto = "Rafael Lillo";

            var ciptografado = cesar.Criptografa(texto);

            Console.WriteLine(ciptografado);
        }

        [TestMethod]
        public void DeCriptografia()
        {
            var cesar = new Cesar();

            string texto = "Rafael Lillo";

            var ciptografado = cesar.Criptografa(texto);

            Console.WriteLine(ciptografado);

            var descriptografado = cesar.Decriptografa(ciptografado);

            Console.WriteLine(descriptografado);
        }

    }
}
