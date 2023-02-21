using Microsoft.Aspnetcore.Mvc;

namespace BaiThucHanh.controller
{
    public class ClassController : controller
    {
        public IActionResult Index ()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
