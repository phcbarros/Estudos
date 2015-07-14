using System;
using WebApplication.Models.Enums;
using WebApplication.Models.Interfaces;
using WebApplication.Models.Interfaces.Logs;

namespace WebApplication.Models.Logs
{
    public class Log : ILog
    {
        #region Propriedades
        public IUsuario Usuario { get; private set; }
        public Operacao Operacao { get; private set; }
        public DateTime DataHora { get; private set; }
        #endregion

        #region Construtores
        public Log(Operacao operacao)
        {
            IUsuario usuario = new Usuario();
            usuario.RecuperarUsuarioLogado();
            usuario.ValidarId();

            this.Usuario = usuario;
            this.Operacao = operacao;
            this.DataHora = DateTime.Now;
        }
        #endregion

    }
}