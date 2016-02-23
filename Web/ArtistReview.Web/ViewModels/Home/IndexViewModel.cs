namespace ArtistReview.Web.ViewModels.Home
{
    using System.Collections.Generic;
    using Categories;
    using Profiles;

    public class IndexViewModel
    {
        public IEnumerable<JokeViewModel> Jokes { get; set; }

        public IEnumerable<DetailsProfileViewModel> Profiles { get; set; }

        public IEnumerable<DetailsCategoryViewModel> Categories { get; set; }
    }
}
