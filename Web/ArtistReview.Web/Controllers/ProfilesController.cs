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

        public ActionResult Index()
        {
            var profile = this.profiles.GetAll().To<DetailsProfileViewModel>().ToList();
            var viewModel = new ProfileViewModel
            {
                Profiles = profile
            };
            return this.View(viewModel);
        }
    }
}
