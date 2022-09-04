using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieListAppDaigh.Models;

namespace MovieListAppDaigh.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

