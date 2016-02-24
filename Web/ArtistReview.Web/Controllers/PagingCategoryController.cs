namespace ArtistReview.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Areas.Administrator.Models.Category;
    using Infrastructure.Mapping;
    using Services.Data;
    using ViewModels.Categories;

    public class PagingCategoryController : BaseController
    {
        private readonly ICategoriesService categories;

        public PagingCategoryController(ICategoriesService categories)
        {
            this.categories = categories;
        }


        public ActionResult Index(int profId, int pageId = 1)
        {
            this.TempData["Profile"] = profId;
            var itemsPerPage = 4;
            var page = pageId;
            var allItemsCount = this.categories.GetAll().Count();
            var totalPages = (int)Math.Ceiling(allItemsCount / (decimal)itemsPerPage);
            var itemsToSkip = (page - 1) * itemsPerPage;
            var categories = this.categories.GetAll()
                .OrderByDescending(x => x.CreatedOn)
                .ThenBy(x => x.Id)
                .Skip(itemsToSkip)
                .Take(itemsPerPage)
                .To<ViewModels.Categories.DetailsCategoryViewModel>().ToList();

            var viewModel = new PagingCategoryViewModel
            {
                CurrentPage = page,
                TotalPages = totalPages,
                Categories = categories
            };
            return this.PartialView(viewModel);
        }

    }
}
