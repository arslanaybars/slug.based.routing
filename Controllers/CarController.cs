using Microsoft.AspNetCore.Mvc;
using slug.based.routing.Domains;

namespace slug.based.routing.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index(string view, Car car)
        {
            return View(view, car);
        }
    }
}
