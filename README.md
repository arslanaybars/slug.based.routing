
# Localized Slug Based Routing ASP.NET Core
This sample solution of optimizing URLs. Basically via the sample we are creating localized human friendly URLs.

Write URL for human
> http://aybarsoft.com/beautiful/url/`
>
instead of
>http://aybarsoft.com/pages/123/`

Here is my route mapping look like:
```csharp
app.UseMvc(routes =>
{
    routes.MapRoute(
        name: "CustomRouterWithCulture",
        template: "{culture::regex(^[a-z]{{2}}$)}/{slug1}/{slug2?}",
        defaults: new { controller = "Home", action = "Router" });

    routes.MapRoute(
        name: "CustomRouter",
        template: "{slug1}/{slug2?}", // ... goes depends on your slug level
        defaults: new { controller = "Home", action = "Router" });

    routes.MapRoute(
        name: "default",
        template: "{controller=Home}/{action=Index}/{id?}");
});
```
We welcome the requests at Home/Router 🚀 

```csharp
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
```
The sample demonstrate simple slug based strategy. You can upgrade domain and controller logic depends on your need.. 👏🏻

Enjoy!

### License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE) file for details
