using NUnit.Framework;
using SpecsFor.Mvc;

namespace pear.web.specs
{
    [SetUpFixture]
    public class SpecsForMvcConfig
    {
        private SpecsForIntegrationHost _integrationHost;

        [SetUp]
        public void TestFixtureSetUp()
        {
            var config = new SpecsFor.Mvc.SpecsForMvcConfig();
            config.UseIISExpress()
                  .With(Project.Named("pear.web"))
                  .ApplyWebConfigTransformForConfig("Debug");

            config.UseBrowser(BrowserDriver.InternetExplorer);

            config.BuildRoutesUsing(r => RouteConfig.RegisterRoutes(r));
                  
            _integrationHost = new SpecsForIntegrationHost(config);
            _integrationHost.Start();
        }

        [TearDown]
        public void TestFixtureTearDown()
        {
            _integrationHost.Shutdown();
        }
    }
}