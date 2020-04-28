namespace ObjectHashGenerator.Interface
{
    public interface IEncryptBuilder
    {
        IEncryptBuilder UseFilter();
        IEncryptBuilder UseFilter(IFilterContext context);
        IEncryptBuilder UseOrder();
        IEncryptBuilder UseOrder(IOrderContext context);
        IEncrypt BuildEncrypt();

    }
}
