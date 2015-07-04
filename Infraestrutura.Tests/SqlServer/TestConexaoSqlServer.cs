using Infraestrutura.SqlServer;
using NUnit.Framework;
using System.Data.SqlClient;
using System.Data;

namespace Infraestrutura.Tests.SqlServer
{
    [TestFixture]
    public class TestConexaoSqlServer
    {
        private SqlConnection Conexao;

        [TestFixtureSetUp]
        public void Setup()
        {
            Conexao = ConexaoSqlServer.GetConnection();
        }

        [Test]
        public void ObjetoDeConexaoFoiCriado()
        {
            Assert.IsNotNull(Conexao);
        }

        [Test]
        public void ConexaoFoiAberta()
        {
            Assert.DoesNotThrow(Conexao.Open);
            Assert.IsTrue(Conexao.State == ConnectionState.Open);
        }

    }
}