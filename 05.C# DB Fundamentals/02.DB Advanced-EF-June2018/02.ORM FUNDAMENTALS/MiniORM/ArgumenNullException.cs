using System;
using System.Runtime.Serialization;

namespace MiniORM
{
    [Serializable]
    internal class ArgumenNullException : Exception
    {
        public ArgumenNullException()
        {
        }

        public ArgumenNullException(string message, string v) : base(message)
        {
        }

        public ArgumenNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArgumenNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}