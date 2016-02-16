namespace ArtistReview.Web.ViewModels.Home
{
    using System;
    using ArtistReview.Data.Models;
    using ArtistReview.Web.Infrastructure.Mapping;
    using AutoMapper;
    public class CategoryViewModel : IMapFrom<Category>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Category, CategoryViewModel>()
                .ForMember(m => m.ImagePath, opt => opt.MapFrom(t => t.Image.ImagePath))
                .ReverseMap();
        }
    }
}
