using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh0703.Models;
using BaiThucHanh0703.Models.Process;

namespace BaiThucHanh0703.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    GiaiPhuongTrinh GPT = new GiaiPhuongTrinh();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult GBTB1()
    {
        return View();
    }
    [HttpPost]

     public IActionResult GBTB1(string hesoA, string hesoB)
    {
        double a = 0,b = 0;
        string thongbao = GPT.GiaiPhuongTrinhB1(a , b);
        if(!string.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA);
        if(!string.IsNullOrEmpty(hesoB)) b = Convert.ToDouble(hesoB);
        if(a == 0 ){
            thongbao = "Khong phai phuong trinh bac nhat";
        }
        else{
            thongbao = GPT.GiaiPhuongTrinhB1(a,b);
        }
        ViewBag.message = thongbao;

        return View();
    }
    

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
