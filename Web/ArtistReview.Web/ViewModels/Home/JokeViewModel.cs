﻿namespace ArtistReview.Web.ViewModels.Home
{
    using ArtistReview.Data.Models;
    using ArtistReview.Services.Web;
    using AutoMapper;
    using ArtistReview.Web.Infrastructure.Mapping;

    public class JokeViewModel : IMapFrom<Joke>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string Category { get; set; }

        public string Url
        {
            get
            {
                IIdentifierProvider identifier = new IdentifierProvider();
                return $"/Joke/{identifier.EncodeId(this.Id)}";
            }
        }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Joke, JokeViewModel>()
                .ForMember(x => x.Category, opt => opt.MapFrom(x => x.Category.Name));
        }
    }
}
