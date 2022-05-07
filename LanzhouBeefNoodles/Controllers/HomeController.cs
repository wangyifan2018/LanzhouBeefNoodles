using LanzhouBeefNoodles.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LanzhouBeefNoodles.ViewModels;
using System.Linq;

namespace LanzhouBeefNoodles.Controllers
{
    //[Route("[controller]")]
    public class HomeController : Controller
    {
        private INoodleRepository _noodleRepository;
        private IFeedbackRepository _feedbackRepository;
        
        public HomeController(INoodleRepository noodleRepository, IFeedbackRepository feedbackRepository)
        {
            _noodleRepository = noodleRepository;
            _feedbackRepository = feedbackRepository;

        }

        //[Route("[action]")]
        // GET: HomeController
        public IActionResult Index()
        {
            //var noodles = _noodleRepository.GetAllNoodles();
            var viewModle = new HomeViewModel()
            {
                Feedbacks = _feedbackRepository.GetAllFeedbacks().ToList(),
                Noodles = _noodleRepository.GetAllNoodles().ToList()

            };
            return View(viewModle);
        }
        //[Route("[action]")]
        // GET: HomeController/Details/5
        public string About()
        {
            return "Hello From About";
        }

    }
}
