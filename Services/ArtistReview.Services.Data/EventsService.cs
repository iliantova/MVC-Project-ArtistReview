namespace ArtistReview.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ArtistReview.Data.Common;
    using ArtistReview.Data.Models;

    public class EventsService : IEventsService
    {
        private readonly IDbRepository<Event> events;

        public EventsService(IDbRepository<Event> events)
        {
            this.events = events;
        }


        public IQueryable<Event> GetAll()
        {
            return events.All();
        }

        public Event GetById(int id)
        {
            return events.GetById(id);
        }

        public IQueryable<Event> GetByCategory(int id)
        {
            return events.All().Where(x => x.CategoryId == id);
        }
    }
}
