namespace WebApplication.Dao.Tabelas
{
    public class TblClientes
    {
        #region Propriedades
        public string Id { get; private set; }
        public string Nome { get; private set; }
        public string Status_Id { get; private set; }
        public string NomeTabela { get; private set; }
        #endregion

        #region Construtores
        public TblClientes()
        {
            this.Id = "id";
            this.Nome = "nome";
            this.Status_Id = "status_id";
            this.NomeTabela = "clientes";
        }
        #endregion
    }
}