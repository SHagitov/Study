using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
