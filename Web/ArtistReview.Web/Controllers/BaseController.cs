namespace ArtistReview.Web.Controllers
{
    using System.Web.Mvc;
    using ArtistReview.Services.Web;
    using AutoMapper;
    using Infrastructure.Mapping;

    public abstract class BaseController : Controller
    {
        public ICacheService Cache { get; set; }

        protected IMapper Mapper
        {
            get
            {
                return AutoMapperConfig.Configuration.CreateMapper();
            }
        }
    }
}
