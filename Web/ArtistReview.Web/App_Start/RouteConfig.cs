namespace ArtistReview.Web
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "CategoriesList",
               url: "Categories/Details/{id}",
               defaults: new { controller = "Categories", action = "Details", id = UrlParameter.Optional },
               namespaces: new[] { "ArtistReview.Web.Controllers" });

            routes.MapRoute(
                name: "JokePage",
                url: "Joke/{id}",
                defaults: new { controller = "Jokes", action = "ById" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(
              name: "Categories",
              url: "Categories/{action}/{id}",
              defaults: new { controller = "Categories", action = "Index", id = UrlParameter.Optional },
            namespaces: new[] { "ArtistReview.Web.Controllers" });
        }
    }
}
