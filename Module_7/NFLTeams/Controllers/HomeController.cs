using Microsoft.AspNetCore.Mvc;
using NFLTeams.Models;
using System.Diagnostics;

namespace NFLTeams.Controllers
{
    public class HomeController : Controller
    {
        private TeamContext context;
        public HomeController(TeamContext ctx)
        {
            context = ctx;
        }
        public ViewResult Index(string activeConf = "all", string activeDiv = "all")
        {
            var model = new TeamListViewModel {
                ActiveConf = activeConf,
                ActiveDiv = activeDiv,
                Conferences = context.Conferences.ToList(),
                Divisions = context.Divisions.ToList()

            };

            //conferences.Insert(0, new Conference { ConferenceID = "all", Name = "All" });
            //divisions.Insert(0, new Division { DivisionID = "all", Name = "All" });

            //ViewBag.Conferences = conferences; ViewBag.Divisions = divisions;

            IQueryable<Team> query = context.Teams; if (activeConf != "all") query = query.Where(
            t => t.Conference.ConferenceID.ToLower() == activeConf.ToLower());
            if (activeDiv != "all") query = query.Where(t => t.Division.DivisionID.ToLower() == activeDiv.ToLower());

            model.Teams = query.ToList(); 

            return View(model);
        }
    }

}