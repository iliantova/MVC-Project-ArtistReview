using ArtistReview.Data.Models;
using System.Linq;

namespace ArtistReview.Services.Data
{
    public interface IProfilesService
    {
        IQueryable<Profile> GetAll();

        Profile GetById(int id);
    }
}
