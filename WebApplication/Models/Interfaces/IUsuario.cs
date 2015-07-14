namespace WebApplication.Models.Interfaces
{
    public interface IUsuario : IModel<IUsuario>
    {
        #region Propriedades
        string Nome { get; }
        string Email { get; }
        string Senha { get; }
        #endregion

        #region Recuperar Usuário Logado
        void RecuperarUsuarioLogado();
        #endregion

        #region Validações
        bool ValidarAcesso(out int usuarioId);
        #endregion

        #region Sair
        void LogOff();
        #endregion
    }
}
