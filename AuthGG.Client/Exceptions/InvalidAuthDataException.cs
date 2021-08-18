using System;

namespace tcortega.AuthGG.Client.Exceptions
{
    public class InvalidAuthDataException : Exception
    {
        public InvalidAuthDataException()
            : base("Invalid auth data provided!")
        {
        }

        public InvalidAuthDataException(string errorMessage)
            : base(errorMessage)
        {
        }
    }
}
