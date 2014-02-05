using NUnit.Framework;
using SpecsFor;
using SpecsFor.Mvc;
using SpecsFor.Mvc.Helpers;
using Should;
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
        public void ItGetsRoutedCorrectly()
        {
            SUT.Route.ShouldMapTo<HomeController>(c => c.Index());
        }

        [Test]
        public void ItIsRunningInDebugMode()
        {
            SUT.FindDisplayFor<HomeIndexViewModel>().DisplayFor(m => m.Environment).Text.ShouldEqual("Debug");
        }
    }
}
