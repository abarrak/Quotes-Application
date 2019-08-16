using System;

namespace QuotesApp.Domain.Exceptions
{
    public class AppBusinessException : AppBaseException
    {
        public AppBusinessException() : base() { }
        public AppBusinessException(string message) : base(message) { }
        public AppBusinessException(string message, Exception innerException) : base(message, innerException) { }
    }
}
