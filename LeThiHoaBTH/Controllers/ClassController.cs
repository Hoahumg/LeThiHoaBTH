using Microsoft.AspNetCore.Mvc;

namespace LeThiHoaBTH.Controllers;

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