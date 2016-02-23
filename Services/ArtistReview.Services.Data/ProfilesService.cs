using ArtistReview.Data.Common;
using ArtistReview.Data.Models;
using System.Linq;

namespace ArtistReview.Services.Data
{
    public class ProfilesService : IProfilesService
    {
        private readonly IDbRepository<Profile> profiles;

        public ProfilesService(IDbRepository<Profile> profiles)
        {
            this.profiles = profiles;
        }

        public IQueryable<Profile> GetAll()
        {
            return profiles.All();
        }

        public Profile GetById(int id)
        {
            return profiles.GetById(id);
        }

        public IQueryable<Profile> GetByCategory(int id)
        {
            return profiles.All().Where(x => x.CategoryId == id);
        }
        
    }
}
