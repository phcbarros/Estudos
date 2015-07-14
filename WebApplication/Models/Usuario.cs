using System;
using WebApplication.Models.Interfaces;

namespace WebApplication.Models
{
    public class Usuario : ClasseBase, IUsuario
    {
        #region Propriedades
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        #endregion

        #region Construtores
        public Usuario()
        {

        }
        #endregion

        #region Entrar e Sair do Sistema
        public void RecuperarUsuarioLogado()
        {
            this.Id = 1;
            //throw new NotImplementedException();
        }

        public bool ValidarAcesso(out int usuarioId)
        {
            throw new NotImplementedException();
        }

        public void LogOff()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Alterar
        public bool Alterar()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Consultar
        public IUsuario Consultar(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Inativar
        public bool Inativar()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Inserir
        public void Inserir()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}