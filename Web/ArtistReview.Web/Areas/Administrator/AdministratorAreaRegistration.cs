using System.Web.Mvc;

namespace ArtistReview.Web.Areas.Administrator
{
    public class AdministratorAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Administrator";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Administrator_default",
                "Administrator/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
             name: "Administrator_Categories",
             url: "Administrator/{controller}/{action}/{id}",
             defaults: new { action = "Index", id = UrlParameter.Optional },
           namespaces: new[] { "ArtistReview.Web.Areas.Administrator.Controllers" });
        }
    }
}