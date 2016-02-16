namespace ArtistReview.Services.Data
{
    using System;
    using System.Linq;

    using ArtistReview.Data.Common;
    using ArtistReview.Data.Models;

    public class CategoriesService : ICategoriesService
    {
        private readonly IDbRepository<Category> categories;

        public CategoriesService(IDbRepository<Category> categories)
        {
            this.categories = categories;
        }

        public Category EditCategory(string name, string descriptions, Image picture)
        {
            var category = this.categories.All().FirstOrDefault(x => x.Name == name);
            if (category != null)
            {
                return category;
            }

            category = new Category {
                Name = name,
                Description = descriptions,
                Image = picture
            };
            this.categories.Add(category);
            this.categories.Save();
            return category;
        }

        public IQueryable<Category> GetAll()
        {
            return this.categories.All().OrderBy(x => x.Name);
        }

        public Category GetById(int id)
        {
            return this.categories.GetById(id);
        }
    }
}
