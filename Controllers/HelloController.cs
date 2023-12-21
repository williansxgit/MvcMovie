using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;

public class HelloController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Welcome(string? name, int numTimes=1)
    {
        return View();
    }
}