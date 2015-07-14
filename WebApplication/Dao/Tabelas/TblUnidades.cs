namespace WebApplication.Dao.Tabelas
{
    public class TblUnidades
    {
        #region Propriedades
        public string Id { get; private set; }
        public string Nome { get; private set; }
        public string Clientes_Id { get; private set; }
        public string Status_Id { get; private set; }
        public string NomeTabela { get; private set; }
        #endregion

        #region Construtores
        public TblUnidades()
        {
            this.Id = "id";
            this.Nome = "nome";
            this.Clientes_Id = "clientes_id";
            this.Status_Id = "status_id";
            this.NomeTabela = "unidades";
        }
        #endregion
    }
}