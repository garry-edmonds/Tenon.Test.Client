using System;

namespace Tenon.Test.Client.Exceptions
{
    public class InvalidStringLengthException : Exception
    {
        public InvalidStringLengthException() { }

        public InvalidStringLengthException(string message) : base(message) { }

        public InvalidStringLengthException(string message, Exception inner) : base(message, inner) { }
        
    }
}
