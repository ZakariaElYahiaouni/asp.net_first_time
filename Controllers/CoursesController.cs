using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myCourse.Models;

namespace myCourse.Controllers;

public class CoursesController : Controller
{
    private readonly ILogger<CoursesController> _logger;

    public CoursesController(ILogger<CoursesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(); 
    }
    public IActionResult Detail(){
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
