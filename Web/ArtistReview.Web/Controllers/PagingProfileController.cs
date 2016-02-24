namespace ArtistReview.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using ArtistReview.Services.Data;
    using ArtistReview.Web.Infrastructure.Mapping;
    using ArtistReview.Web.ViewModels.Profiles;

    public class PagingProfileController : BaseController
    {
        private readonly IProfilesService profiles;

        public PagingProfileController(IProfilesService profiles)
        {
            this.profiles = profiles;
        }

        public ActionResult Index(int catId, int pageId = 1)
        {
            this.TempData["Category"] = catId;
            var itemsPerPage = 4;
            var page = pageId;
            var allItemsCount = this.profiles.GetAll().Count();
            var totalPages = (int)Math.Ceiling(allItemsCount / (decimal)itemsPerPage);
            var itemsToSkip = (page - 1) * itemsPerPage;
            var profiles = this.profiles.GetAll()
                .OrderByDescending(x => x.CreatedOn)
                .ThenBy(x => x.Id)
                .Skip(itemsToSkip)
                .Take(itemsPerPage)
                .To<DetailsProfileViewModel>().ToList();

          var viewModel = new PaginProfileViewModel
            {
              CurrentPage = page,
              TotalPages = totalPages,
              Profiles = profiles
            };
            return this.PartialView(viewModel);
        }

    }
}