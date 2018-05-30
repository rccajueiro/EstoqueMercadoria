using System;
using EstoqueMercadoriaEngine.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EstoqueMercadoriaTest.Models
{
    [TestClass]
    public class EstoqueModelTest
    {
        [TestMethod]
        public void TestInstance()
        {
            new EstoqueModel();
            Equals(true);
        }

        [TestMethod]
        public void TestGetValorTotal()
        {
            EstoqueModel Estoque = new EstoqueModel();

            Random Rand = new Random();

            double ValorTotal = 0;

            int RandQtd = 0;
            double RandValor = 0;

            for (int i = 0; i < 5; i++)
            {
                RandQtd = Rand.Next();
                RandValor = Math.Round(Rand.NextDouble() * Rand.Next(), 2);

                Estoque.Mercadorias.Add(new MercadoriaModel(RandQtd, RandValor));

                ValorTotal += RandQtd * RandValor;
            }

            Assert.AreEqual(ValorTotal, Estoque.GetValorTotal());
        }

        [TestMethod]
        public void TestGetQtdTotal()
        {
            EstoqueModel Estoque = new EstoqueModel();

            Random Rand = new Random();

            int QtdTotal = 0;

            int RandQtd = 0;
            double RandValor = 0;

            for (int i = 10; i < 30; i += 10)
            {
                RandQtd = Rand.Next();
                RandValor = Math.Round(Rand.NextDouble() * Rand.Next(), 2);

                Estoque.Mercadorias.Add(new MercadoriaModel(RandQtd, RandValor));

                QtdTotal += RandQtd;
            }

            Assert.AreEqual(QtdTotal, Estoque.GetQtdTotal());
        }

        [TestMethod]
        public void TestGetMediaValor()
        {
            EstoqueModel Estoque = new EstoqueModel();

            Random Rand = new Random();

            int QtdTotal = 0;
            double ValorTotal = 0;

            int RandQtd = 0;
            double RandValor = 0;

            for (int i = 10; i < 30; i += 10)
            {
                RandQtd = Rand.Next();
                RandValor = Math.Round(Rand.NextDouble() * Rand.Next(), 2);

                Estoque.Mercadorias.Add(new MercadoriaModel(RandQtd, RandValor));

                QtdTotal += RandQtd;
                ValorTotal += RandQtd * RandValor;
            }

            Assert.AreEqual(Math.Round(ValorTotal / QtdTotal, 2), Estoque.GetMediaValor());
        }
    }
}
