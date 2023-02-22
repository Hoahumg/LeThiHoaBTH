 using Microsoft.AspNetCore.Mvc;

namespace LeThiHoa2002.Controllers;

    public class ClassController : Controller
    
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }