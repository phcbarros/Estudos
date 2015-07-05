using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Models.Interfaces;

namespace WebApplication.Models
{
    public class Unidade : ClasseBase, IUnidade
    {
        public string Nome { get; private set; }
        public ICliente Cliente { get; private set; }
    }
}