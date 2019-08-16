using System;

namespace QuotesApp.Domain.Exceptions
{
    public class AppNotFoundException : AppBaseException
    {
        public AppNotFoundException() : base() { }
        public AppNotFoundException(string message) : base(message) { }
        public AppNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}
