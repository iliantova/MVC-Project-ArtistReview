namespace ArtistReview.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using ArtistReview.Services.Data;
    using Infrastructure.Mapping;
    using ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IJokesService jokes;
        private readonly ICategoriesService jokeCategories;

        public HomeController(
            IJokesService jokes,
            ICategoriesService jokeCategories)
        {
            this.jokes = jokes;
            this.jokeCategories = jokeCategories;
        }

        public ActionResult Index()
        {
            var jokes = this.jokes.GetRandomJokes(3).To<JokeViewModel>().ToList();
            var categories =
                this.Cache.Get(
                    "categories",
                    () => this.jokeCategories.GetAll().To<CategoryViewModel>().ToList(),
                    30 * 60);
            var viewModel = new IndexViewModel
            {
                Jokes = jokes,
                Categories = categories
            };

            return this.View(viewModel);
        }
    }
}
