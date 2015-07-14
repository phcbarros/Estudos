namespace WebApplication.Models.Interfaces.Crud
{
    public interface IConsultar<out T> where T : class
    {
        #region Consultar
        T Consultar(int id);
        #endregion
    }
}
