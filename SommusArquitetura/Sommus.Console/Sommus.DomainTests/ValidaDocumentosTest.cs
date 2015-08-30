using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sommus.Domain;

namespace Sommus.DomainTests
{
    [TestClass]
    public class ValidaDocumentosTest
    {
        [TestMethod]
        public void ClienteCNPJTest()
        {
            Clientes c = new Clientes();
            c.CNPJ = "04717475000154";

            Assert.IsTrue(ValidadoresDocumento.ValidaCNPJ(c.CNPJ));
        }

        [TestMethod]
        public void FornecedorCNPJTest()
        {
            Fornecedores f = new Fornecedores();
            f.CNPJ = "04717475000154";

            Assert.IsTrue(ValidadoresDocumento.ValidaCNPJ(f.CNPJ));
        }
    }
}
