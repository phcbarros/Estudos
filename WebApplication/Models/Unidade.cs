using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Models.Enums;
using WebApplication.Models.Interfaces;

namespace WebApplication.Models
{
    public class Unidade : ClasseBase, IUnidade
    {
        public string Nome { get; private set; }
        public ICliente Cliente { get; private set; }
        public Unidade()
        {

        }
        public Unidade(int id, string nome, Status status)
        {
            this.Id = id;
            this.Nome = nome;
            this.Status = status;
        }
        public IList<IUnidade> Unidades(ICliente model)
        {
            throw new NotImplementedException();
        }
    }
}