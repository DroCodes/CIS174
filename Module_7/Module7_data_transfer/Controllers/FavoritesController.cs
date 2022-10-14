using Microsoft.AspNetCore.Mvc;
using Module7_data_transfer.Models;

namespace Module7_data_transfer.Controllers
{
    public class FavoritesController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var session = new CountrySession(HttpContext.Session);
            var model = new CountryListViewModel
            {
                ActiveCat = session.GetActiveCat(),
                ActiveGame = session.GetActiveGame(),
                Country = session.GetMyCountry(),
            };
            return View(model);
        }
        
        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new CountrySession(HttpContext.Session);
            session.RemoveMyCountry();

            TempData["message"] = "Favorite teams cleared";

            return RedirectToAction("Index", "Home",
                new {
                    ActiveCat = session.GetActiveCat(),
                    ActiveGame = session.GetActiveGame()
            });
        }
    }
}
