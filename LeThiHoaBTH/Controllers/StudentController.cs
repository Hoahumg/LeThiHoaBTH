   using Microsoft.AspNetCore.Mvc;

namespace LeThiHoaBTH.Controllers;

    public class StudentController : Controller
    
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