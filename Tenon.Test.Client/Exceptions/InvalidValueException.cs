using System;

namespace Tenon.Test.Client.Exceptions
{
    public class InvalidValueException : Exception
    {
        public InvalidValueException() { }

        public InvalidValueException(string message) : base(message) { }

        public InvalidValueException(string message, Exception inner) : base(message, inner) { }
    }
}
