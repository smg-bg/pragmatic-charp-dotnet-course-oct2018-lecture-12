using System;
using System.Runtime.Serialization;

namespace ExceptionDetails
{
    // custom exceptione example
    // 
    [Serializable]
    public class PragmaticException : Exception
    {
        public PragmaticException() : base()
        {

        }

        public PragmaticException(string message): base(message)
        {
            
        }

        public PragmaticException(string message, Exception innerException) : base(message, innerException)
        {

        }


        protected PragmaticException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
