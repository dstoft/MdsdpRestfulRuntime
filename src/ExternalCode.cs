using System.Collections.Generic;
using EmTest;
using EmTest.Models;

namespace RestfulRuntime
{
    public class ExternalCode : IExternalCode
    {
        public bool VerifyString(string parameter)
        {
            return true;
        }

        public bool VerifyPassword(string parameter)
        {
            return true;
        }

        public bool VerifyCpr(int parameter)
        {
            return true;
        }

        public bool VerifyBooks(List<Resource1> parameter)
        {
            return true;
        }
    }
}