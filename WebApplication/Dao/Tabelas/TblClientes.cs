﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Dao.Tabelas
{
    public class TblClientes
    {
        public string Id { get; private set; }
        public string Nome { get; private set; }
        public string Status_Id { get; private set; }
        public string NomeTabela { get; private set; }
        public TblClientes()
        {
            this.Id = "clientes.id";
            this.Nome = "clientes.nome";
            this.Status_Id = "clientes.status_id";
            this.NomeTabela = "clientes";
        }
    }
}