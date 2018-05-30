using System;
using EstoqueMercadoriaEngine.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EstoqueMercadoriaTest
{
    [TestClass]
    public class MercadoriaModelTest
    {
        [TestMethod]
        public void TestInstance()
        {
            new MercadoriaModel(10, 10);
            Equals(true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), MercadoriaModel.EXCEPTION_MESSAGE_QTD_TOTAL_MENOR_0)]
        public void TestQtdMenorZero()
        {
            new MercadoriaModel(-1, 10.00);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), MercadoriaModel.EXCEPTION_MESSAGE_VALOR_MENOR_0)]
        public void TestValorMenorZero()
        {
            new MercadoriaModel(10, -10.00);
        }

        [TestMethod]
        public void TestValorTotal()
        {
            double Valor = 13.45;
            int QtdTotal = 10;

            Assert.AreEqual(Valor * QtdTotal, new MercadoriaModel(QtdTotal, Valor).GetValorTotal());
        }
    }
}
