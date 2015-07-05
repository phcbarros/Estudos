using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Dao.Tabelas
{
    public class TblUnidades
    {
        public string Id { get; private set; }
        public string Nome { get; private set; }
        public string Clientes_Id { get; private set; }
        public string Status_Id { get; private set; }
        public string NomeTabela { get; private set; }
        public TblUnidades()
        {
            this.Id = "unidades.id";
            this.Nome = "unidades.nome";
            this.Clientes_Id = "unidades.clientes_id";
            this.Status_Id = "unidades.status_id";
            this.NomeTabela = "unidades";
        }
    }
}