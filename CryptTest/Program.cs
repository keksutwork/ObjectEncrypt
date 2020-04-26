using ObjectHashGenerator;
using System;
using TruCrypt;

namespace CryptTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestModel model = new TestModel()
            {
                Price = "100",
            };

            Encrypt.MD5Encryption(model);



            Console.Read();
        }
    }

}
