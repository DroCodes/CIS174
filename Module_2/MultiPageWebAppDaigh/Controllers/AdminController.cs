using Microsoft.AspNetCore.Mvc;

namespace MultiPageWebAppDaigh.Controllers
{
    public class AdminController : Controller
    {
        [Route("home/admin")]
        public IActionResult Admin()
        {
            return View();
        }
    }
}
