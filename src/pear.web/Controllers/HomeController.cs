using System.Configuration;
using System.Web.Mvc;

namespace pear.web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var viewModel = new HomeIndexViewModel {Environment = ConfigurationManager.AppSettings["Environment"]};
            
            return View(viewModel);
        }

    }

    public class HomeIndexViewModel
    {
        public string Environment { get; set; }
    }
}
