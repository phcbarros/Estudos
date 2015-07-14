namespace WebApplication.Dao.Interfaces.Crud
{
    public interface IInativar<in T> where T : class
    {
        #region Inativar
        bool Inativar(T model);
        #endregion
    }
}
