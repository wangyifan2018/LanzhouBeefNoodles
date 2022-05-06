using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LanzhouBeefNoodles.Controllers
{
    public class NoddleController : Controller
    {
        public IList<string> Index()
        {
            return new List<string> {"牛肉面", "羊肉面", "鸡蛋面" };
        }
    }
}
