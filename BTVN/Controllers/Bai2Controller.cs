using Microsoft.AspNetCore.Mvc;
using BTVN.Models;

namespace BTVN.Controllers
{
    public class Bai2Controller : Controller
    {
        [HttpGet]
        public IActionResult Bai2()
        {
            return View("calculate");
        }

        [HttpPost]
public IActionResult Bai2(Bai2 model)
{
    double result = 0;

    switch (model.Operation)
    {
        case "add": result = model.Number1 + model.Number2; break;
        case "sub": result = model.Number1 - model.Number2; break;
        case "mul": result = model.Number1 * model.Number2; break;
        case "div": result = model.Number2 != 0 ? model.Number1 / model.Number2 : 0; break;
    }

    ViewBag.Result = result;
    return View("calculate", model); 
}
    }
}