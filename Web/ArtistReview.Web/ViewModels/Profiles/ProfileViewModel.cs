namespace ArtistReview.Web.ViewModels.Profiles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using ArtistReview.Web.ViewModels.Categories;

    public class ProfileViewModel
    {
        public IEnumerable<DetailsProfileViewModel> Profiles { get; set; }
    }
}