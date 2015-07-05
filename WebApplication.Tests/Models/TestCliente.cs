using System;
using NUnit.Framework;
using WebApplication.Models;

namespace WebApplication.Tests.Models
{
    [TestFixture]
    public class TestCliente
    {
        private Cliente Cliente;

        [TestFixtureSetUp]
        public void SetUp()
        {
            this.Cliente = new Cliente();
        }

        [Test]
        public void ListaContemItens()
        {
            var clientes = this.Cliente.Listar();
            Assert.IsNotNull(clientes);
            Assert.IsTrue(clientes.Count > 0);
        }
    }
}
