using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiPageWebAppDaigh.Models;

namespace MultiPageWebAppDaigh.Controllers
{
    public class HomeController : Controller
    {
        private ContactsContext context { get; set; }
        public HomeController(ContactsContext ctx)
        {
            context = ctx;
        }
        [Route("/")]
        public IActionResult Index()
        {
            var listContacts = context.Contact.OrderBy(c => c.Name).ToList();
            return View(listContacts);
        }
    }
}
