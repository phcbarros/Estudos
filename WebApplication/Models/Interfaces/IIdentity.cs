namespace WebApplication.Models.Interfaces
{
    public interface IIdentity
    {
        int Id { get; }
        void ValidarModelo();
    }
}
