namespace WebApplication.Models.Interfaces.Persistencia
{
    public interface IIdentity
    {
        int Id { get; }
        void ValidarModelo();
    }
}
