using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using slug.based.routing.DbContext;

namespace slug.based.routing.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Router(string culture, string slug1, string slug2)
        {
            // Get content by latest slug
            if (!string.IsNullOrEmpty(slug2)) { return ReturnSlugAction(slug2, culture); }

            if (!string.IsNullOrEmpty(slug1)) { return ReturnSlugAction(slug1, culture); }

            return RedirectPermanent("/");
        }

        private IActionResult ReturnSlugAction(string slug, string culture)
        {
            culture = string.IsNullOrEmpty(culture) ? "en" : culture;
            var data = _appDbContext.Data.FirstOrDefault(x => x.Translations.Exists(tr => tr.Slug == slug && tr.Culture == culture));

            // if slug is not exist return home page
            if (data == null) { return RedirectPermanent("/"); }

            data.ViewTranslations = data.Translations.FirstOrDefault(x => x.Culture == culture);
            var typeName = data.GetType().Name;
            var controllerName = typeName + "Controller";
            var type = Type.GetType("slug.based.routing.Controllers." + controllerName);
            var instance = Activator.CreateInstance(type);

            var methodInfo = type.GetMethod("Index");
            var view = "~/Views/" + typeName + "/Index.cshtml";

            return methodInfo.Invoke(instance, new object[] { view, data }) as IActionResult;
        }
    }
}
