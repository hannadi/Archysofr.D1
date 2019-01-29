using System;

namespace Archysoft.D1.Model.Exceptions
{
    public class BusinessException : Exception
    {
        public int Status { get; set; }
        public string Description { get; set; }

        public BusinessException(string message) : base(message)
        { }

        public BusinessException(int status, string message) : base(message)
        {
            Status = status;
            Description = message;
        }

        public BusinessException(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
