namespace ArtistReview.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using ArtistReview.Services.Data;
    using ArtistReview.Web.Infrastructure.Mapping;
    using ArtistReview.Web.ViewModels.Categories;
    using ViewModels.Profiles;
    using ViewModels.Events;
    public class CategoriesController : BaseController
    {
        private readonly ICategoriesService categories;
        private readonly IProfilesService profiles;
        private readonly IEventsService events;

        public CategoriesController( ICategoriesService categories, IProfilesService profiles, IEventsService events)
        {
            this.categories = categories;
            this.profiles = profiles;
            this.events = events;
        }

        // GET: Categories
        public ActionResult Details(int id = 1)
        {
            var profiles = this.profiles.GetByCategory(id).To<DetailsProfileViewModel>().ToList();
            var events = this.events.GetByCategory(id).To<DetailsEventViewModel>().ToList();
            var category = this.Mapper.Map<DetailsCategoryViewModel>(this.categories.GetById(id));

            var viewModel = new CurrentCategoryViewModel
            {
                Category = category,
                Profiles = profiles,
                Events = events

            };

            return this.View(viewModel);

            return this.View("Error");
        }

        // GET: Categories
        public ActionResult Index()
        {
            var category = this.categories.GetAll().To<DetailsCategoryViewModel>().ToList();
            var viewModel = new CategoryViewModel
            {
                Categories = category,

            };
            return this.View(viewModel);
        }
    }
}