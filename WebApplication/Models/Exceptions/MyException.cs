using System;

namespace WebApplication.Models.Exceptions
{
    [Serializable]
    public class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
    }
}