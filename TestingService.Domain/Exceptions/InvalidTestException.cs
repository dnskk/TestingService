using System;

namespace TestingService.Domain.Exceptions
{
    /// <summary>
    /// Exception is thrown if test is invalid.
    /// </summary>
    public class InvalidTestException : Exception
    {
        /// <inheritdoc/>
        public InvalidTestException(string message)
            : base(message)
        {
        }
    }
}
