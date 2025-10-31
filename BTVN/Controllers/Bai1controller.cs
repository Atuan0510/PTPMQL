using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTVN.Models;

namespace Net_Core.Controllers;

public class Bai1Controller : Controller
{
    private readonly ILogger<Bai1Controller> _logger;

    public Bai1Controller(ILogger<Bai1Controller> logger)
    {
        _logger = logger;
    }

    public string Index()
    {
        return "Hello from Bai 1 Controller";
    }

    public IActionResult Privacy()
    {
        return View();
    }


    [HttpGet]
        public IActionResult Bai1()
        {
            return View("info");
        }

        [HttpPost]
        public IActionResult Bai1(string name, int yearOfBirth)
        {
            int age = DateTime.Now.Year - yearOfBirth;
            ViewBag.Name = name;
            ViewBag.Age = age;
            return View("info");
        }






    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}