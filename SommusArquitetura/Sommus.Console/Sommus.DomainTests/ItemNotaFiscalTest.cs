using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sommus.Domain;

namespace Sommus.DomainTests
{
    [TestClass]
    public class ItemNotaFiscalTest
    {
        [TestMethod]
        public void TestaValorTotal()
        {
            ItensNotasFiscais i = new ItensNotasFiscais();

            i.Quantidade = 10;
            i.ValorUnitario = 250;

            Assert.AreEqual(i.ValorTotal, 2500);
        }

        [TestMethod]
        public void TestaValorICMS()
        {
            ItensNotasFiscais i = new ItensNotasFiscais();

            i.Quantidade = 10;
            i.ValorUnitario = 10;
            i.Imposto = ICMS.CalculaICMS(i.ValorTotal);

            Assert.AreEqual(i.Imposto, 8);
        }

        [TestMethod]
        public void TestaValorLiquido()
        {
            ItensNotasFiscais i = new ItensNotasFiscais();

            i.Quantidade = 10;
            i.ValorUnitario = 10;
            i.Imposto = ICMS.CalculaICMS(i.ValorTotal);
            
            Assert.AreEqual(i.ValorLiquido, 92);
        }
    }
}
