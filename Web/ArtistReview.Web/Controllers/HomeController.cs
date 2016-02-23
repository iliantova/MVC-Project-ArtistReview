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

        public ActionResult Index()
        {
            var profiles = this.profiles.GetAll().To<DetailsProfileViewModel>().ToList();

            var jokes = this.jokes.GetRandomJokes(3).To<JokeViewModel>().ToList();
            var categories =
                this.Cache.Get(
                    "categories",
                    () => this.jokeCategories.GetAll().To<DetailsCategoryViewModel>().ToList(),
                    30 * 60);
            var viewModel = new IndexViewModel
            {
                Jokes = jokes,
                Categories = categories,
                Profiles = profiles
            };

            return this.View(viewModel);
        }
    }
}
