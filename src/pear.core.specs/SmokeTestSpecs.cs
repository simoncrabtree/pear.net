using NUnit.Framework;
using SpecsFor;
using pear.web.specs;

namespace pear.core.specs
{
    [TestFixture]
    public class SmokeTestSpecs : SpecsFor<OrderProcessor>
    {

        protected override void Given()
        {
            GetMockFor<IInventory>()
            .Setup(i => i.CreateNewOrder())
            .Returns("Hello")
            .Verifiable();

        }

        protected override void When()
        {
            SUT.PlaceOrder(new Order());
        }

        [Test]
        public void PlaceOrder()
        {
            GetMockFor<IInventory>().Verify();
        }
    }
}
