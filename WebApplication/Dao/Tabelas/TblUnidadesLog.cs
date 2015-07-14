namespace WebApplication.Dao.Tabelas
{
    public class TblUnidadesLog
    {
        #region Propriedades
        public string Unidades_Id { get; private set; }
        public string Unidades_Nome { get; private set; }
        public string Unidades_Clientes_Id { get; private set; }
        public string Unidades_Status_Id { get; private set; }
        public string Usuarios_Id { get; private set; }
        public string Operacao_Id { get; private set; }
        public string DataHora { get; private set; }
        public string NomeTabela { get; private set; }
        #endregion

        #region Construtores
        public TblUnidadesLog()
        {
            this.Unidades_Id = "unidades_id";
            this.Unidades_Nome = "unidades_nome";
            this.Unidades_Clientes_Id = "unidades_clientes_id";
            this.Unidades_Status_Id = "unidades_status_id";
            this.Usuarios_Id = "usuarios_id";
            this.Operacao_Id = "operacao_id";
            this.DataHora = "datahora";
            this.NomeTabela = "unidades_log";
        }
        #endregion
    }
}