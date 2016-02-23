using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtistReview.Data.Models;
using ArtistReview.Data.Common;

namespace ArtistReview.Services.Data
{
    public class EventsService : IEventsService
    {
        private readonly IDbRepository<Event> events;

        public IQueryable<Event> GetAll()
        {
            return events.All();
        }

        public Event GetById(int id)
        {
            return events.GetById(id);
        }
    }
}
