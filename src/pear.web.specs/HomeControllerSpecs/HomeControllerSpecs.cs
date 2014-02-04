using NUnit.Framework;
using SpecsFor;
using SpecsFor.Mvc;
using SpecsFor.Mvc.Helpers;
using pear.web.Controllers;

namespace pear.web.specs.HomeControllerSpecs
{
    public class NavigateToHomePage : SpecsFor<MvcWebApp>
    {
        protected override void When()
        {
            SUT.NavigateTo<HomeController>(c => c.Index());
        }

        [Test]
        public void then_it_sends_email()
        {
            SUT.Route.ShouldMapTo<HomeController>(c => c.Index());
        }
    }
}
