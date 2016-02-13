namespace ArtistReview.Services.Data
{
    using System.Linq;

    using ArtistReview.Data.Models;

    public interface IJokesService
    {
        IQueryable<Joke> GetRandomJokes(int count);

        Joke GetById(string id);
    }
}
