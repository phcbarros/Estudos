namespace WebApplication.Models.Interfaces.Persistencia
{
    public interface IIdentity
    {
        #region Propriedades
        int Id { get; }
        #endregion

        #region Validações
        void ValidarId();
        #endregion
    }
}
