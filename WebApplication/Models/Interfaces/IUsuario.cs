namespace WebApplication.Models.Interfaces
{
    public interface IUsuario
    {
        string Nome { get; }
        string Email { get; }
        string Senha { get; }
        IUsuario RecuperarUsuarioLogado();
        bool ValidarAcesso(out int usuarioId);
        void LogOff();
    }
}
