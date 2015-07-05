using WebApplication.Models.Enums;

namespace WebApplication.Models
{
    public abstract class ClasseBase
    {
        #region Propriedades
        public int Id { get; protected set; }
        public Status Status { get; protected set; }
        #endregion
    }
}