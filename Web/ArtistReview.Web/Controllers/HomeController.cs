namespace ArtistReview.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using ArtistReview.Services.Data;
    using Infrastructure.Mapping;
    using ViewModels.Home;
    using ViewModels.Categories;
    using ViewModels.Profiles;
    public class HomeController : BaseController
    {
        private readonly IJokesService jokes;
        private readonly ICategoriesService jokeCategories;
        private readonly IProfilesService profiles;

        public HomeController(
            IJokesService jokes,
            ICategoriesService jokeCategories,
            IProfilesService profiles)
        {
            this.jokes = jokes;
            this.jokeCategories = jokeCategories;
            this.profiles = profiles;
        }

        public ActionResult Index(int pageIdProfile = 1, int pageIdCategory = 1)
        {
            ViewData["PageProfil"] = pageIdProfile;
            ViewData["PageCategory"] = pageIdCategory;
            return this.View();
        }
    }
}
