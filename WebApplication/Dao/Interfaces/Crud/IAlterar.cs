namespace WebApplication.Dao.Interfaces.Crud
{
    public interface IAlterar<in T> where T : class
    {
        #region Alterar
        bool Alterar(T model);
        #endregion
    }
}
