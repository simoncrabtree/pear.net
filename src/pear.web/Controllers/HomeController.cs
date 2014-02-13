using System.Web.Mvc;

namespace pear.web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
<<<<<<< HEAD
            var viewModel = new HomeIndexViewModel {Environment = ConfigurationManager.AppSettings["Environment"]};
            
            return View(viewModel);
=======
            return View();
>>>>>>> parent of 53f15fe... Home_Index view displays the environment setting from the config file
        }

    }

    public class HomeIndexViewModel
    {
        public string Environment { get; set; }
    }
}
