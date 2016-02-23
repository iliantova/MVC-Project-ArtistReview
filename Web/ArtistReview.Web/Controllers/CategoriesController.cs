namespace ArtistReview.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using ArtistReview.Services.Data;
    using ArtistReview.Web.Infrastructure.Mapping;
    using ArtistReview.Web.ViewModels.Categories;
    using ArtistReview.Web.ViewModels.Home;

    public class CategoriesController : BaseController
    {
        private readonly ICategoriesService categories;

        public CategoriesController( ICategoriesService categories)
        {
            this.categories = categories;
        }

        // GET: Categories
        public ActionResult Details(int id = 1)
        {
            //int categoryId;
            //if (int.TryParse(id, out categoryId))
            //{
                var category = this.Mapper.Map<DetailsCategoryViewModel>(this.categories.GetById(id));
                return this.View(category);
            //}
            
            return this.View("Error");
        }

        // GET: Categories
        public ActionResult Index()
        {
            var category = this.categories.GetAll().To<DetailsCategoryViewModel>().ToList();
            var viewModel = new CategoryViewModel
            {
                Categories = category
            };
            return this.View(viewModel);
        }
    }
}