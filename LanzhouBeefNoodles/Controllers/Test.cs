using Microsoft.AspNetCore.Mvc;
namespace LanzhouBeefNoodles.Controllers
{
    [Controller]
    public class TestController : Controller
    {
        //[Route("[action]")]
        // GET: HomeController
        public ActionResult Index()
        {
            return Content("Hello From test index");
        }
        //[Route("[action]")]
        // GET: HomeController/Details/5
        public string About()
        {
            return "Hello From test About";
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
