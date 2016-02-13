namespace ArtistReview.Web.ViewModels.Home
{
    using ArtistReview.Data.Models;
    using ArtistReview.Web.Infrastructure.Mapping;

    public class JokeCategoryViewModel : IMapFrom<JokeCategory>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
