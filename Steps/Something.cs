using System;
using System.Collections;

namespace Steps
{
    public class SomethingС : IEnumerator
    {
        public object Current { get; }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
