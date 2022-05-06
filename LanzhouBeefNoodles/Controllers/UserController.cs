using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LanzhouBeefNoodles.Controllers
{
    [Route("admin/[controller]/[action]")]
    public class UserController : Controller
    {
        public IList<string> Index()
        {
            return new List<string> { "阿莱克斯", "马克思", "马斯克"};
        }
    }
}
