using Microsoft.AspNetCore.Mvc;
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
    }
}