using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cripto_Teste.Conceito
{
    [TestClass]
    public class Matematica
    {
        [TestMethod]
        public void MaiorDivisor()
        {
            var n1 = new BigInteger(14);
            var n2 = new BigInteger(0); 
            var r = BigInteger.GreatestCommonDivisor(n1, n2);
        }
    }
}
