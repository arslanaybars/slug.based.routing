using Microsoft.AspNetCore.Mvc;
using slug.based.routing.Domains;

namespace slug.based.routing.Controllers
{
    public class ShipController : Controller
    {
        public IActionResult Index(string view, Ship ship)
        {
            return View(view, ship);
        }
    }
}
