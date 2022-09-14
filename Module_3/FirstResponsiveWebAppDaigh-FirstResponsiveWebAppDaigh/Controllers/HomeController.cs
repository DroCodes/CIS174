using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppDaigh.Models;

namespace FirstResponsiveWebAppDaigh.Controllers
{
    public class HomeController : Controller
    {
        const int DEFAULT_VALUE = 0;
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = "John Doe";
            ViewBag.Age = DEFAULT_VALUE;
            ViewBag.YearFormat = "YYYY";
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculateAgeModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = model.Name;
                ViewBag.Age = model.AgeThisYear();
            }
            else
            {
                ViewBag.Name = "John Doe";
                ViewBag.Age = DEFAULT_VALUE;
            }
            
            return View();
        }
    }
}
