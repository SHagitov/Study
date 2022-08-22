using System;

namespace Steps
{
    public class SomethingException : Exception
    {
        public SomethingException(string Msg, int Code) : base(Msg)
        {
            ErrorCode = Code;
        }
        public int ErrorCode { get; set; }
    }
}
