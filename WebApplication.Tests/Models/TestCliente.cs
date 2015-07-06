using System;
using NUnit.Framework;
using WebApplication.Dao;
using WebApplication.Dao.Interfaces;
using WebApplication.Models;
using WebApplication.Models.Interfaces;

namespace WebApplication.Tests.Models
{
    [TestFixture]
    public class TestCliente
    {
        private Cliente Cliente;

        [TestFixtureSetUp]
        public void SetUp()
        {
            this.Cliente = new Cliente(1);
        }

        [Test]
        public void ListaContemItens()
        {
            var clientes = this.Cliente.Listar();
            Assert.IsNotNull(clientes);
            Assert.IsTrue(clientes.Count > 0);
        }

        [Test]
        public void PossuiUnidades()
        {
            this.Cliente.PreencherUnidades();
            Assert.IsNotNull(this.Cliente.Unidades);
            Assert.IsTrue(this.Cliente.Unidades.Count > 0);
        }

        [Test]
        public void Cadastrar()
        {
            ICliente cliente = new Cliente("Jessé " + DateTime.Now);
            cliente.Inserir();

            Assert.AreNotEqual(0, cliente.Id);
        }
    }
}
