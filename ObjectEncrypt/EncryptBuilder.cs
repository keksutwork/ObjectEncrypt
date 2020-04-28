using ObjectHashGenerator.Interface;
using System;

namespace ObjectHashGenerator
{
    public class EncryptBuilder : IEncryptBuilder
    {
        IEncrypt IEncryptBuilder.BuildEncrypt()
        {
            throw new NotImplementedException();
        }

        IEncryptBuilder IEncryptBuilder.UseFilter()
        {
            throw new NotImplementedException();
        }

        IEncryptBuilder IEncryptBuilder.UseFilter(IFilterContext context)
        {
            throw new NotImplementedException();
        }

        IEncryptBuilder IEncryptBuilder.UseOrder()
        {
            throw new NotImplementedException();
        }

        IEncryptBuilder IEncryptBuilder.UseOrder(IOrderContext context)
        {
            throw new NotImplementedException();
        }
    }
}
