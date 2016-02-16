namespace ArtistReview.Services.Data
{
    using System.Linq;

    using ArtistReview.Data.Models;

    public interface ICategoriesService
    {
        IQueryable<Category> GetAll();

        Category EditCategory(string name, string descriptions, Image picture);

        Category GetById(int id);
    }
}
