namespace ArtistReview.Web.ViewModels.Home
{
    using System.Collections.Generic;
    using Categories;
    using Profiles;

    public class IndexViewModel
    {
        public IEnumerable<PaginProfileViewModel> Profiles { get; set; }

        public IEnumerable<PagingCategoryViewModel> Categories { get; set; }
    }
}
