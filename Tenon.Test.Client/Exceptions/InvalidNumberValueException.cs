using System;

namespace Tenon.Test.Client.Exceptions
{
    class InvalidNumberValueException : Exception
    {
        public InvalidNumberValueException() { }
        public InvalidNumberValueException(string message) : base(message) { }
        public InvalidNumberValueException(string message, Exception inner) : base(message, inner) { }
        
    }
}
