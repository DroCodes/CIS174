using Microsoft.AspNetCore.Mvc;
using MultiPageWebAppDaigh.Models;

namespace MultiPageWebAppDaigh.Controllers
{
    public class ContactsController : Controller
    {
        private ContactsContext context { get; set; }

        public ContactsController(ContactsContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddContact", new Contacts());
        }

        [HttpPost]
        public IActionResult Add(Contacts contact)
        {
            if (ModelState.IsValid)
            {
                context.Contact.Add(contact);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(contact);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contact.Find(id);
            return View("DeleteContact", contact);
        }

        [HttpPost]
        public IActionResult Delete(Contacts contact)
        {
            context.Contact.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
