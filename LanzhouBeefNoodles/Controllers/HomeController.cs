using LanzhouBeefNoodles.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LanzhouBeefNoodles.Controllers
{
    //[Route("[controller]")]
    public class HomeController : Controller
    {
        private INoodleRepository _noodleRepository;
        
        public HomeController(INoodleRepository noodleRepository)
        {
            _noodleRepository = noodleRepository;
        }

        //[Route("[action]")]
        // GET: HomeController
        public IActionResult Index()
        {
            var noodles = _noodleRepository.GetAllNoodles();
            return View(noodles);
        }
        //[Route("[action]")]
        // GET: HomeController/Details/5
        public string About()
        {
            return "Hello From About";
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}
