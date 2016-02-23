namespace ArtistReview.Web.ViewModels.Events
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using ArtistReview.Web.Infrastructure.Mapping;
    using AutoMapper;
    using Data.Models;

    public class DetailsEventViewModel : IMapFrom<Event>, IHaveCustomMappings
    {
        public int Id { get; set; }

        //[Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        //[Required]
        [MinLength(3)]
        [MaxLength(500)]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        //[Required]
        public DateTime? BeginEvent { get; set; }

        public DateTime? EndEvent { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public virtual Category Category { get; set; }

        public string UserName { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Data.Models.Event, DetailsEventViewModel>()
                .ForMember(m => m.CategoryName, opt => opt.MapFrom(t => t.Category.Name));
            configuration.CreateMap<Data.Models.Event, DetailsEventViewModel>()
                .ForMember(m => m.UserName, opt => opt.MapFrom(t => t.User.UserName));
            configuration.CreateMap<Data.Models.Event, DetailsEventViewModel>()
            .ForMember(m => m.ImageUrl, opt => opt.MapFrom(t => t.Image.ImagePath));
        }
    }
}