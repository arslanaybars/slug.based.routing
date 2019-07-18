using Microsoft.AspNetCore.Mvc;
using slug.based.routing.Domains;

namespace slug.based.routing.Controllers
{
    public class MotorcycleController : Controller
    {
        public IActionResult Index(string view, Motorcycle motorcycle)
        {
            return View(view, motorcycle);
        }
    }
}
