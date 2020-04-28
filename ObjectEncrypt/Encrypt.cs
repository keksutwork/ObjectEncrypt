
using ObjectHashGenerator.Interface;

namespace ObjectHashGenerator
{
    public static class Encrypt
    {
        public static IEncryptBuilder CreateBuilder()
        {
            return new EncryptBuilder();
        }

    }
}