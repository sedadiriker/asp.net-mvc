using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using asp.net_mvc.Models;

namespace asp.net_mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [Route("/shop")]
    public IActionResult Shop()
    {
        return View();
    }
     [Route("/blog")]
    public IActionResult Blog()
    {
        return View();
    }
     [Route("/contact")]
    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
