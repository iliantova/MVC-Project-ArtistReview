using ArtistReview.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArtistReview.Web.ViewModels.Home;

namespace ArtistReview.Web.Controllers
{
    public class CategoriesController : BaseController
    {
        private readonly ICategoriesService categories;
        public CategoriesController( ICategoriesService categories)
        {

            this.categories = categories;
        }

        // GET: Categories
        public ActionResult Details(string id)
        {
            int categoryId;
            if (int.TryParse(id, out categoryId))
            {
                var category = this.Mapper.Map<CategoryViewModel>(this.categories.GetById(categoryId));
                return this.View(category);
            }
            
            return this.View("Error");
        }
    }
}