namespace ArtistReview.Web.Areas.Administrator.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Infrastructure.Mapping;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using Models.Category;
    using Services.Data;

    public class CategoriesAdminController : BaseController
    {
        private readonly ICategoriesService categories;

        public CategoriesAdminController(ICategoriesService categories)
        {
            this.categories = categories;
        }

        // GET: Administrator/Categories
        public ActionResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Read([DataSourceRequest]DataSourceRequest request)
        {
            var categoriesList = this.categories.GetAll();

            var result = categoriesList.To<DetailsCategoryViewModel>()
        .ToDataSourceResult(request);
            return this.Json(result);
        }

        public ActionResult Create()
        {
            return this.View();
        }

        public ActionResult Update()
        {
            return this.View();
        }

        public ActionResult Destroy()
        {
            return this.View();
        }
    }
}