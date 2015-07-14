namespace WebApplication.Dao.Tabelas
{
    public class TblClientesLog
    {
        #region Propriedades
        public string Clientes_Id { get; private set; }
        public string Clientes_Nome { get; private set; }
        public string Clientes_Status_Id { get; private set; }
        public string Usuarios_Id { get; private set; }
        public string Operacao_Id { get; private set; }
        public string DataHora { get; private set; }
        public string NomeTabela { get; private set; }
        #endregion

        #region Construtores
        public TblClientesLog()
        {
            this.Clientes_Id = "clientes_id";
            this.Clientes_Nome = "clientes_nome";
            this.Clientes_Status_Id = "clientes_status_id";
            this.Usuarios_Id = "usuarios_id";
            this.Operacao_Id = "operacao_id";
            this.DataHora = "datahora";
            this.NomeTabela = "clientes_log";
        }
        #endregion
    }
}