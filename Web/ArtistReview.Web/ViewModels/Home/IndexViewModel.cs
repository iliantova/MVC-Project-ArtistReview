namespace ArtistReview.Web.ViewModels.Home
{
    using Categories;
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public IEnumerable<JokeViewModel> Jokes { get; set; }

        public IEnumerable<DetailsCategoryViewModel> Categories { get; set; }
    }
}
