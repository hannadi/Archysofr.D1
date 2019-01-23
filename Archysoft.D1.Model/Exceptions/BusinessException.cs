using System;

namespace Archysoft.D1.Model.Exceptions
{
    public class BusinessException : Exception
    {
        public BusinessException(string message) : base(message)
        { }
        public BusinessException(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
