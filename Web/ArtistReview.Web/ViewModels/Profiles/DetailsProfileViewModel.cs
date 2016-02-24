namespace ArtistReview.Web.ViewModels.Profiles
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using ArtistReview.Data.Models;
    using ArtistReview.Web.Infrastructure.Mapping;
    using AutoMapper;

    public class DetailsProfileViewModel : IMapFrom<Data.Models.Profile>, IHaveCustomMappings
    {
        public string Description { get; set; }

        public string Site { get; set; }

        public string FaceBook { get; set; }

        public string Contact { get; set; }

        public int CategoryId { get; set; }

        [Display(Name = "Category:")]
        public string CategoryName { get; set; }

        public virtual Category Category { get; set; }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        public virtual ICollection<Image> Images { get; set; }

        public string ImageUrl { get; set; }

        public virtual ApplicationUser User { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Data.Models.Profile, DetailsProfileViewModel>()
                .ForMember(m => m.CategoryName, opt => opt.MapFrom(t => t.Category.Name));
            configuration.CreateMap<Data.Models.Profile, DetailsProfileViewModel>()
                .ForMember(m => m.FirstName, opt => opt.MapFrom(t => t.User.FirstName));
            configuration.CreateMap<Data.Models.Profile, DetailsProfileViewModel>()
               .ForMember(m => m.LastName, opt => opt.MapFrom(t => t.User.LastName));
            configuration.CreateMap<Data.Models.Profile, DetailsProfileViewModel>()
              .ForMember(m => m.ImageUrl, opt => opt.MapFrom(t => t.Images.FirstOrDefault().ImagePath));
        }
    }
}
