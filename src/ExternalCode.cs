using EmTest;

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

        public bool fishing(int parameter)
        {
            return true;
        }
    }
}