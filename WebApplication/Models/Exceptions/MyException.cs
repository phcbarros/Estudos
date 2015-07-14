using System;

namespace WebApplication.Models.Exceptions
{
    [Serializable]
    public class MyException : Exception
    {
        #region Construtores
        public MyException() { }
        public MyException(string message) : base(message) { }
        #endregion
    }
}