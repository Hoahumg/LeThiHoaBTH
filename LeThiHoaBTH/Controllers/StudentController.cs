using Microsoft.Aspnetcore.Mvc;

namespace BaiThucHanh.controller
{
    public class StudentController : controller
    {
        public IActionResult Index ()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
