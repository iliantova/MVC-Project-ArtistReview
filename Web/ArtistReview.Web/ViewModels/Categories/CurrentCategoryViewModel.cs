namespace ArtistReview.Web.ViewModels.Categories
{
    using System.Collections.Generic;
    using Events;
    using Profiles;

    public class CurrentCategoryViewModel
    {
        public IEnumerable<DetailsProfileViewModel> Profiles { get; set; }

        public IEnumerable<DetailsEventViewModel> Events { get; set; }

        public DetailsCategoryViewModel Category { get; set; }
    }
}