namespace ArtistReview.Web.Controllers
{
    using System.Web.Mvc;
    using Services.Data;
    using ViewModels.Events;
    using Infrastructure.Mapping;
    public class EventsController : BaseController
    {
        private readonly IEventsService events;

        public EventsController(IEventsService events)
        {
           this.events = events;
        }

        // GET: Events
        public ActionResult Index()
        {

            var events = this.events.GetAll().To<DetailsEventViewModel>();

            var viewModel = new EventsViewModel
            {
                Events = events,

            };
            return this.View(viewModel);
        }
    }
}