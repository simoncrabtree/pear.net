using pear.web.specs;

namespace pear.core
{
    public class CreateProductCommand
    {
        private readonly IProductRepository _productRepository;

        public CreateProductCommand(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public string ProductName { get; set; }

        public bool Execute()
        {
            if (_productRepository.DoesProductExist(ProductName))
            {
                return false;
            };
            return true;
        }
    }
}