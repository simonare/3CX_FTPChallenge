using System;

namespace _3CX_FTPSample
{
    public class CustomApplicationException : ApplicationException
    {
        public CustomApplicationException(string message) : base(message)
        {

        }

        public CustomApplicationException(string message, Exception exception): base(message, exception)
        {
            
        }
    }
}
