namespace pear.core
{
    public interface IProductRepository
    {
        bool DoesProductExist(string name);
    }
}