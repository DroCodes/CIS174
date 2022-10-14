using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Module7_data_transfer.Models;
using System.Diagnostics;

namespace Module7_data_transfer.Controllers
{
    public class HomeController : Controller
    {
        private CountryContext context;
        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }
        public ViewResult Index(string activeCat = "all", string activeGame = "all")
        {
            var session = new CountrySession(HttpContext.Session);
            session.SetActiveCat(activeCat);
            session.SetActiveGame(activeGame);

            var model = new CountryListViewModel
            {
                ActiveCat = activeCat,
                ActiveGame = activeGame,
                Categories = context.Categories.ToList(),
                Games = context.Games.ToList()

            };

            IQueryable<Country> query = context.Countrys; 
            if (activeCat != "all") query = query.Where(t => t.Category.CategoryID.ToLower() == activeCat.ToLower());
            if (activeGame != "all") query = query.Where(t => t.Game.GameID.ToLower() == activeGame.ToLower());

            model.Country = query.ToList();

            return View(model);
        }

        public IActionResult Details(string id)
        {
            var session = new CountrySession(HttpContext.Session);
            var model = new CountryViewModel
            {
                Country = context.Countrys
                    .Include(c => c.Category).Include(c => c.Game).FirstOrDefault(c => c.CountryID == id),

                ActiveGame = session.GetActiveGame(),
                ActiveCat = session.GetActiveCat()
            };

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(CountryViewModel model)
        {
            model.Country = context.Countrys.Include(c => c.Category).Include(c => c.Game).Where(c => c.CountryID == model.Country.CountryID).FirstOrDefault();

            var session = new CountrySession(HttpContext.Session);
            var countries = session.GetMyCountry();
            countries.Add(model.Country);
            session.SetMyCountry(countries);

            TempData["Message"] = $"{model.Country.Name} added to your favorites";

            return RedirectToAction("Index",
                new
                {
                    ActiveCat = session.GetActiveCat(),
                    ActiveGame = session.GetActiveGame()
                });
        }
    }
}