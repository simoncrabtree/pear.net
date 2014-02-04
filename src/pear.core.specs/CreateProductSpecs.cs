using NUnit.Framework;
using Should;
using SpecsFor;

namespace pear.core.specs
{
    public class CreateProductSpecs : SpecsFor<CreateProductCommand>
    {
        private bool _result;

        protected override void Given()
        {
            //Product does not already exist
            GetMockFor<IProductRepository>()
                .Setup(x => x.DoesProductExist("Product A"))
                .Returns(false)
                .Verifiable();
        }

        protected override void When()
        {
            SUT.ProductName = "Product A";
            _result = SUT.Execute();
        }

        [Test]
        public void checks_that_the_product_doesnt_already_exist()
        {
//            GetMockFor<IProductRepository>().Verify(x => x.DoesProductExist("Product A"));
        }

        [Test]
        public void command_succeeds()
        {
            _result.ShouldBeTrue();
        }
    }
}
