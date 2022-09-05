using System.Linq;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieListAppDaigh.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieListAppDaigh.Controllers;

public class HomeController : Controller
{
    private MovieContext context { get; set; }
    public HomeController(MovieContext ctx)
    {
        context = ctx;
    }
    public IActionResult Index()
    {
        var movies = context.Movies.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
        return View(movies);
    }
}

