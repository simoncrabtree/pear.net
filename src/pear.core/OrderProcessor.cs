using pear.core;

namespace pear.web.specs
{
    public class OrderProcessor
    {
        private readonly IInventory _inventory;

        public OrderProcessor(IInventory inventory)
        {
            _inventory = inventory;
        }

        public void PlaceOrder(Order order)
        {
            _inventory.CreateNewOrder();

        }
    }
}