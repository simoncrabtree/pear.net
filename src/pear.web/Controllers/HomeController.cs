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
            ViewBag.Environment = ConfigurationManager.AppSettings["Environment"];
            
            return View();
        }

    }
}
