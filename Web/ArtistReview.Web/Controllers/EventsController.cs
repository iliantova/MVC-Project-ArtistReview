namespace ArtistReview.Web.Controllers
{
    using System.Web.Mvc;
    using Services.Data;
    using ViewModels.Events;
    using Infrastructure.Mapping;
    using System;
    using System.Linq;
    public class EventsController : BaseController
    {
        private readonly IEventsService events;

        public EventsController(IEventsService events)
        {
           this.events = events;
        }

        // GET: Events
        public ActionResult Index(string searchString)
        {
            var events = this.events.GetAll().To<DetailsEventViewModel>();

            if (!String.IsNullOrEmpty(searchString))
            {
                events = events.Where(s => s.Name.ToLower().Contains(searchString.ToLower()));
            }

            var viewModel = new EventsViewModel
            {
                Events = events,

            };
            return this.View(viewModel);
        }

        public ActionResult Details(int id = 1)
        {
            var eventModel = this.Mapper.Map<DetailsEventViewModel>(this.events.GetById(id));

            return this.View(eventModel);
        }
    }
}