namespace ArtistReview.Web.ViewModels.Categories
{
    using ArtistReview.Data.Models;
    using ArtistReview.Web.Infrastructure.Mapping;
    using AutoMapper;
    using Profiles;
    using System.Collections.Generic;
    public class DetailsCategoryViewModel : IMapFrom<Category>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public IEnumerable<DetailsProfileViewModel> Profiles { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Category, DetailsCategoryViewModel>()
                .ForMember(m => m.ImagePath, opt => opt.MapFrom(t => t.Image.ImagePath))
                .ReverseMap();
        }
    }
}
