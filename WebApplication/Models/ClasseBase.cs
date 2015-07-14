using WebApplication.Models.Enums;
using WebApplication.Models.Exceptions;

namespace WebApplication.Models
{
    public abstract class ClasseBase
    {
        #region Propriedades
        public int Id { get; protected set; }
        public Status Status { get; protected set; }
        #endregion

        #region Validações
        /// <exception cref="MyException"></exception>
        public virtual void ValidarId()
        {
            if (this == null || this.Id <= 0)
                throw new MyException("Id é obrigatório!");
        }
        #endregion
    }
}