namespace WebApplication.Dao.Interfaces.Crud
{
    public interface IInserir<in T> where T : class
    {
        #region Inserir
        int Inserir(T model);
        #endregion
    }
}
