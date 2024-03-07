using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace logistik.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["ActivePage"] = "Home";
        return View();
    }

    public IActionResult About()
    {
        ViewData["ActivePage"] = "About";
        return View();
    }

    public IActionResult Services()
    {
        ViewData["ActivePage"] = "Services";
        return View();
    }

    public IActionResult Contact()
    {
        ViewData["ActivePage"] = "Contact";
        return View();
    }
}
