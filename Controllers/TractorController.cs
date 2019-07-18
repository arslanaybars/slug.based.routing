using Microsoft.AspNetCore.Mvc;
using slug.based.routing.Domains;

namespace slug.based.routing.Controllers
{
    public class TractorController : Controller
    {
        public IActionResult Index(string view, Tractor tractor)
        {
            return View(view, tractor);
        }
    }
}
