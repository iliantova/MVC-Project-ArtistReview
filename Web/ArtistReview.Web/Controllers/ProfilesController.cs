namespace ArtistReview.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Infrastructure.Mapping;
    using Services.Data;
    using ViewModels.Profiles;

    public class ProfilesController : BaseController
    {
        private readonly IProfilesService profiles;


        public ProfilesController(IProfilesService profiles)
        {
            this.profiles = profiles;
        }

        public ActionResult Index(string searchString)
        {
            var profile = this.profiles.GetAll().To<DetailsProfileViewModel>().ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                profile = profile.Where(s => s.FullName.ToLower().Contains(searchString.ToLower())).ToList();
            }

            var viewModel = new ProfileViewModel
            {
                Profiles = profile
            };
            return this.View(viewModel);
        }

        public ActionResult Details(int id = 1)
        {
            var profile = this.Mapper.Map<DetailsProfileViewModel>(this.profiles.GetById(id));

            return this.View(profile);
        }
    }
}
