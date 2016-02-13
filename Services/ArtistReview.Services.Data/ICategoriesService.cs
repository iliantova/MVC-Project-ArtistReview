namespace ArtistReview.Services.Data
{
    using System.Linq;

    using ArtistReview.Data.Models;

    public interface ICategoriesService
    {
        IQueryable<JokeCategory> GetAll();

        JokeCategory EnsureCategory(string name);
    }
}
